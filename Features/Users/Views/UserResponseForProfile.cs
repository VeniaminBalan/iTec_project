using iTec_project.Features.Profiles.Views;
using iTec_project.Features.Roles.Views;

namespace iTec_project.Features.Users.Views;

public class UserResponseForProfile
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public RoleResponse Role { get; set; }
}