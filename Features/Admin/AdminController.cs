using iTec_project.DataBase;
using iTec_project.Features.Users.Services;
using iTec_project.Features.Users.Views;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace iTec_project.Features.Admin;

[ApiController]
[Route("admin")]
public class AdminController : ControllerBase
{
    
    private readonly AppDbContext _appDbContext;

    public AdminController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    
        
    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserResponse>>> GetAll()
    {
        var user = await _appDbContext.Users
            .Include(r => r.Role)
            .Select(u=>UserService.GetUserResponse(u))
            .ToListAsync();
        
        return Ok(user);
    }
}