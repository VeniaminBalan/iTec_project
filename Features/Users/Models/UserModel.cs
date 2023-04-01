using System.ComponentModel.DataAnnotations.Schema;
using iTec_project.Base;
using iTec_project.Features.Profiles.Models;
using iTec_project.Features.Roles.Models;

namespace  iTec_project.Features.Users.Models;

public class UserModel : Model
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Salt { get; set; }
    public string Hashed { get; set; }
    public RoleModel  Role { get; set; }

}