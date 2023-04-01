using AutoMapper;
using iTec_project.DataBase;
using iTec_project.Features.Profiles.Models;
using iTec_project.Features.Profiles.Services;
using iTec_project.Features.Profiles.Views;
using iTec_project.Features.Roles.Models;
using iTec_project.Utils.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace iTec_project.Features.Profiles;

[ApiController]
[Route("profiles")]
public class ProfilesController : ControllerBase
{
    
    private readonly AppDbContext _appDbContext;

    public ProfilesController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProfileResponse>>> Get()
    {
        var profiles = await _appDbContext.Profiles
            .Include(p=>p.User)
            .Select(p=> ProfileService.GetProfileResponse(p))
            .ToListAsync();

        return Ok(profiles);
    }

    [HttpGet("{Id}")]
    public async Task<ActionResult<ProfileResponse>> Get([FromRoute] string Id)
    {
        var profile = await _appDbContext.Profiles
            .Include(p => p.User)
            .FirstOrDefaultAsync(p=>p.User.Id == Id);

        if (profile is null) return BadRequest("profile not found");
        
        return ProfileService.GetProfileResponse(profile);
    }

    [HttpPatch("{Id}")]
    public async Task<ActionResult<ProfileResponse>> Patch(ProfileRequest request,[FromRoute] string Id)
    {

        return null;
    }

}