using AutoMapper;
using iTec_project.Features.Profiles.Models;
using iTec_project.Features.Profiles.Views;
using iTec_project.Features.Roles.Models;
using iTec_project.Features.Roles.Views;

namespace iTec_project.Utils.Mappers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<RoleModel, RoleRequest>().ReverseMap();
        CreateMap<RoleModel, RoleResponse>().ReverseMap();
        CreateMap<ProfileModel, ProfileResponse>().ReverseMap();
        CreateMap<ProfileModel, ProfileRequest>().ReverseMap();
    }
}