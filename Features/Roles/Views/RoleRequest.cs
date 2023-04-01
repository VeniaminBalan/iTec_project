using System.ComponentModel.DataAnnotations;

namespace iTec_project.Features.Roles.Views;

public class RoleRequest
{
    [Required]public string Name { get; set; }
}