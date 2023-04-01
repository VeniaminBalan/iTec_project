using iTec_project.Features.Profiles.Models;
using iTec_project.Features.Users.Models;
using Microsoft.EntityFrameworkCore;
using iTec_project.Features.Roles.Models;

namespace iTec_project.DataBase;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<UserModel> Users { get; set;}
    public DbSet<RoleModel> Roles { get; set;}
    public DbSet<ProfileModel> Profiles { get; set; }
}