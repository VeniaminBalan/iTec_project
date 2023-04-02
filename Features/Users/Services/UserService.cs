using iTec_project.Features.Profiles.Services;
using iTec_project.Features.Roles.Views;
using iTec_project.Features.Users.Models;
using iTec_project.Features.Users.Views;

namespace iTec_project.Features.Users.Services;

public class UserService
{
    public static UserResponse GetUserResponse(UserModel user)
    {
        return new UserResponse
        {
            
            Id = user.Id,
            StartTime = user.Created,
            Name = user.Name,
            Email = user.Email,
            QuickInfo = user.QuickInfo,
            Position = user.Position,
            Role = new RoleResponse
            {
                Id = user.Role.Id,
                Name = user.Role.Name,
            },
        };
    }

    public static UserResponseForProfile GetUserResponseForProfile(UserModel user)
    {
        return new UserResponseForProfile
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Role = new RoleResponse
            {
                Id = user.Role.Id,
                Name = user.Role.Name,
            }
        };
    }
}