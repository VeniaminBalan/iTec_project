using iTec_project.Features.Users.Views;

namespace iTec_project.Features.Profiles.Views;

public class ProfileResponse
{
    public string Id { get; set; }
    public UserResponseForProfile User { get; set; }
    public DateTime? DateStarted { get; set; } 
    public string? Position { get; set; }
    public int[]? WorkExperience { get; set; } // <1, 1-3, 3-5, 5-10, 10> // {5}
    public int[]? IndustriesWorkExperience { get; set; } // {6}
    public string? OtherOption { get; set; }
    
    public int? DevPost { get; set; } // 1 - frontend, 2 - backend, 3 - both
    
    // Backend Option
    public int[]? BackendFramework { get; set; }
    public string? OtherBackendFrameworkOption { get; set; }
    public int? ProgramingLanguages { get; set; }
    public int[]? BackendFrameworkTools { get; set; }

    //Frontend Option
    public int[]? FrontendFramework { get; set; }
    public string? OtherFrontendFrameworkOption { get; set; }
    public int[]? FrameworkExperience { get; set; }
    public int[]? FrontendFrameworkTools { get; set; }
    
    public int? ComunicationStyle { get; set; }
    public string? OtherComunicationStyle { get; set; }

    public int? ConflictsHandle { get; set; }
    public string? OtherConflictsHandle { get; set; }

    public int[]? CommunicationSkillsRating { get; set; }
    public int[]? TeamWorkAbilityRate { get; set; }

}