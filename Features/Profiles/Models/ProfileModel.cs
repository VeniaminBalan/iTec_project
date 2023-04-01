using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using AutoMapper.Configuration.Annotations;
using iTec_project.Features.Users.Models;
using iTec_project.Base;

namespace iTec_project.Features.Profiles.Models;


public class ProfileModel : Model
{
    public UserModel User { get; set; }
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
    
    public ProfileModel()
    {

        DateStarted = DateTime.UtcNow;
        Position = " ";
        WorkExperience = new int[5];
        IndustriesWorkExperience = new int[5];
        OtherOption = " ";
        DevPost = -1;
        BackendFramework = new int[5];
        OtherBackendFrameworkOption = " ";
        ProgramingLanguages = -1;
        BackendFrameworkTools = new int[5];
        FrontendFramework = new int[5];
        OtherFrontendFrameworkOption = " ";
        FrameworkExperience = new int[5];
        FrontendFrameworkTools = new int[5];
        ComunicationStyle = -1;
        OtherComunicationStyle = " ";
        ConflictsHandle = -1;
        OtherConflictsHandle = " ";
        CommunicationSkillsRating = new int[5];
        TeamWorkAbilityRate  = new int[5];
    }
    
}