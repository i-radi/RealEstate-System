using AutoMapper;
using Core.Bases;
using Data.Entities;

namespace Core.Features.Users.Queries.Results;

public class GetUserByIdResponse : ICustomMapping
{
    public string FullName { get; set; }
    public string Email { get; set; }
    public string? Address { get; set; }
    public string? Country { get; set; }

    public void CreateMappings(Profile configuration)
    {
        configuration.CreateMap<User, GetUserByIdResponse>();
    }
}
