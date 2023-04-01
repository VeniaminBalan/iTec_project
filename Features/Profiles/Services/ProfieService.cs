using iTec_project.Features.Profiles.Models;
using iTec_project.Features.Profiles.Views;
using iTec_project.Features.Users.Models;
using iTec_project.Features.Users.Services;
using iTec_project.Features.Users.Views;

namespace iTec_project.Features.Profiles.Services;

public class ProfileService
{
    public static ProfileResponseForUser GetProfileResponseForUser(ProfileModel profile)
    {
        return new ProfileResponseForUser
        {
            Id = profile.Id,
            DateStarted = profile.DateStarted,
            Position = profile.Position,
            WorkExperience = profile.WorkExperience,
            IndustriesWorkExperience = profile.IndustriesWorkExperience,
            OtherOption = profile.OtherOption,
            DevPost = profile.DevPost,
            BackendFramework = profile.BackendFramework,
            OtherBackendFrameworkOption = profile.OtherBackendFrameworkOption,
            ProgramingLanguages = profile.ProgramingLanguages,
            BackendFrameworkTools = profile.BackendFrameworkTools,
            FrontendFramework = profile.FrontendFramework,
            OtherFrontendFrameworkOption = profile.OtherFrontendFrameworkOption,
            FrameworkExperience = profile.FrameworkExperience,
            FrontendFrameworkTools = profile.FrontendFrameworkTools,
            ComunicationStyle = profile.ComunicationStyle,
            OtherComunicationStyle = profile.OtherComunicationStyle,
            ConflictsHandle = profile.ConflictsHandle,
            OtherConflictsHandle = profile.OtherConflictsHandle,
            CommunicationSkillsRating = profile.CommunicationSkillsRating,
            TeamWorkAbilityRate = profile.TeamWorkAbilityRate
        };
    }
    
    public static ProfileResponse GetProfileResponse(ProfileModel profile)
    {
        return new ProfileResponse
        {
            User = UserService.GetUserResponseForProfile(profile.User),
            
            DateStarted = profile.DateStarted,
            Position = profile.Position,
            WorkExperience = profile.WorkExperience,
            IndustriesWorkExperience = profile.IndustriesWorkExperience,
            OtherOption = profile.OtherOption,
            DevPost = profile.DevPost,
            BackendFramework = profile.BackendFramework,
            OtherBackendFrameworkOption = profile.OtherBackendFrameworkOption,
            ProgramingLanguages = profile.ProgramingLanguages,
            BackendFrameworkTools = profile.BackendFrameworkTools,
            FrontendFramework = profile.FrontendFramework,
            OtherFrontendFrameworkOption = profile.OtherFrontendFrameworkOption,
            FrameworkExperience = profile.FrameworkExperience,
            FrontendFrameworkTools = profile.FrontendFrameworkTools,
            ComunicationStyle = profile.ComunicationStyle,
            OtherComunicationStyle = profile.OtherComunicationStyle,
            ConflictsHandle = profile.ConflictsHandle,
            OtherConflictsHandle = profile.OtherConflictsHandle,
            CommunicationSkillsRating = profile.CommunicationSkillsRating,
            TeamWorkAbilityRate = profile.TeamWorkAbilityRate
        };
    }

    /*
    public static ProfileModel GetProfileModel(ProfileRequest request, UserModel user)
    {
        return new ProfileModel
        {
            User = user,

            DateStarted = request.DateStarted,
            Position = request.Position,
            WorkExperience = request.WorkExperience,
            IndustriesWorkExperience = request.IndustriesWorkExperience,
            OtherOption = request.OtherOption,
            DevPost = request.DevPost,
            BackendFramework = request.BackendFramework,
            OtherBackendFrameworkOption = request.OtherBackendFrameworkOption,
            ProgramingLanguages = request.ProgramingLanguages,
            BackendFrameworkTools = request.BackendFrameworkTools,
            FrontendFramework = request.FrontendFramework,
            OtherFrontendFrameworkOption = request.OtherFrontendFrameworkOption,
            FrameworkExperience = request.FrameworkExperience,
            FrontendFrameworkTools = request.FrontendFrameworkTools,
            ComunicationStyle = request.ComunicationStyle,
            OtherComunicationStyle = request.OtherComunicationStyle,
            ConflictsHandle = request.ConflictsHandle,
            OtherConflictsHandle = request.OtherConflictsHandle,
            CommunicationSkillsRating = request.CommunicationSkillsRating,
            TeamWorkAbilityRate = request.TeamWorkAbilityRate
        };
    }
    */
}