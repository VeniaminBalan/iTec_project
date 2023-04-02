using iTec_project.Features.Profiles.Views;
using iTec_project.Features.Roles.Views;

namespace iTec_project.Features.Users.Views;

public class UserResponse
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    
    public string QuickInfo { get; set; }
    
    public string Position { get; set; }
    public DateTime StartTime { get; set; }
    public RoleResponse Role { get; set; }
}