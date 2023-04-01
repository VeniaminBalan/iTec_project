using AutoMapper;
using iTec_project.DataBase;
using iTec_project.Features.Roles.Models;
using iTec_project.Features.Roles.Views;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace iTec_project.Features.Roles;

[ApiController]
[Route("roles")]
public class RolesController : ControllerBase
{
    private readonly AppDbContext _appDbContext;
    /*
    private readonly IRepository<RoleModel> _repository;
    private readonly IMapper _mapper;
    
    public RolesController(IRepository<RoleModel> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    */
    
    public RolesController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<RoleResponse>> Add([FromBody]RoleRequest request)
    {
        var role = new RoleModel
        {
            Name = request.Name,
        };

        role = (_appDbContext.Add(role)).Entity;
        _appDbContext.SaveChanges();

        var res = new RoleResponse
        {
            Id = role.Id,
            Name = role.Name,
        };

        return Ok(res);
    }
    
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<RoleResponse>>> Get()
    {
        var roles = await _appDbContext.Roles
            .Select(role => new RoleResponse
            {
                Id = role.Id,
                Name = role.Name,
            })
            .ToListAsync();

        return Ok(roles);
    }

    
    
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<RoleResponse>> Get([FromRoute]string id)
    {
        return null;
    }
}