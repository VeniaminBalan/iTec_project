using iTec_project.DataBase;
using iTec_project.Features.Profiles.Models;
using iTec_project.Features.Roles.Views;
using iTec_project.Features.Users.Models;
using iTec_project.Features.Users.Utils;
using iTec_project.Features.Users.Views;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using iTec_project.Features.Profiles.Services;
using iTec_project.Features.Users.Services;

namespace  iTec_project.Features.Users;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    private readonly AppDbContext _appDbContext;

    public UsersController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    
    [HttpPost]
    public async Task<ActionResult<UserResponse>> Add(UserRequest request)
    {
        var role = await _appDbContext.Roles.FirstOrDefaultAsync(r => r.Name == Roles.Roles.NewEmployee );
        if (role is null) return NotFound("Member not found");
        
        var  existingUser = await _appDbContext.Users.FirstOrDefaultAsync(r=> r.Email == request.Email);
        if (existingUser is not null) return BadRequest("User already exists with that email");
        
        //existingUser = await _appDbContext.Users.FirstOrDefaultAsync(r=> r.Name == request.Name);
        //if (existingUser is not null) return BadRequest("User already exists with that name");

        HashPassword hashedPassword = new HashPassword("1111");
        

        var user = new UserModel
        {
            Name = " ",
            QuickInfo = request.QuickInfo,
            Position = request.Position,
            Email = request.Email,
            Salt = hashedPassword.GetSalt(),
            Hashed = hashedPassword.GetHashed(),
            Role = role,
        };
        
        var profile = new ProfileModel();
        profile.User = user;
        
        user = (await _appDbContext.Users.AddAsync(user)).Entity;
        profile = (await _appDbContext.Profiles.AddAsync(profile)).Entity;
        
        await _appDbContext.SaveChangesAsync();

        var res = UserService.GetUserResponse(user);
        
        return Created("user", res);
    }
    
    [HttpGet]
    public async Task<ActionResult<UserResponse>> Get(string Email, string Password)
    {
        var user = await _appDbContext.Users
            .Include(r=>r.Role)
            .FirstOrDefaultAsync(user => user.Email == Email);

        if (user is null) return BadRequest("Email or password are incorect");

        if (!HashPassword.isValid(Password, user.Salt, user.Hashed))
            return BadRequest("Password is incorect");

        var res = UserService.GetUserResponse(user);

        return res;
    }
    
    [HttpPut("{Id}")]
    public async Task<ActionResult<UserResponse>> Put([FromRoute]string Id, string roleName)
    {
        var user = await _appDbContext.Users
            .FirstOrDefaultAsync(u=>u.Id == Id);

        if (user is null) return BadRequest("user not found");

        var role = await _appDbContext.Roles.FirstOrDefaultAsync(r => r.Name == roleName);
        if (role is null) return BadRequest("role not found");

        user.Role = role;
        
        //user = (await _appDbContext.Users.AddAsync(user)).Entity;
        await _appDbContext.SaveChangesAsync();

        return UserService.GetUserResponse(user);
    }
    
}