using System.ComponentModel.DataAnnotations;

namespace iTec_project.Features.Users.Views;

public class UserRequest
{
    [Required]
    public string QuickInfo { get; set; }

    [EmailAddress]
    [Required]
    public string Email { get; set; }
    [Required] public string Position { get; set; }
}