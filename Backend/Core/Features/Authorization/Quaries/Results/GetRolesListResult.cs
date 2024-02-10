using AutoMapper;
using Core.Bases;
using Data.Entities;

namespace Core.Features.Authorization.Quaries.Results;

public class GetRolesListResult : ICustomMapping
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void CreateMappings(Profile configuration)
    {
        configuration.CreateMap<Role, GetRolesListResult>();
    }
}
