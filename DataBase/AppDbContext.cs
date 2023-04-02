using System.Diagnostics;
using iTec_project.Features.Profiles.Models;
using iTec_project.Features.Users.Models;
using Microsoft.EntityFrameworkCore;
using iTec_project.Features.Roles.Models;
using iTec_project.Features.Profiles.Models;
using MySql.EntityFrameworkCore.Extensions;

namespace iTec_project.DataBase;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<UserModel> Users { get; set;}
    public DbSet<RoleModel> Roles { get; set;}
    public DbSet<ProfileModel> Profiles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*
        modelBuilder.Entity<ProfileModel>(builder =>
        {
            if (Database.IsMySql())
            {
                builder.Property(p => p.BackendFramework)
                    .HasConversion(
                        v => v.ToString(),
                        v => 
            }
        });*/
        
        base.OnModelCreating(modelBuilder);
    }
}