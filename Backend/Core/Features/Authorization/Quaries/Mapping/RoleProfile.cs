using AutoMapper;
using Core.Features.Authorization.Quaries.Results;
using Data.Entities;

namespace Core.Features.Authorization.Mapping.Roles;

public partial class RoleProfile : Profile
{
    public RoleProfile()
    {
        CreateMap<Role, GetRoleByIdResult>();
        CreateMap<Role, GetRolesListResult>();
    }
}
