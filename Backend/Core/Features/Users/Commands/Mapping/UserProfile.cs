using AutoMapper;
using Core.Features.Users.Commands.Models;
using Data.Entities;

namespace Core.Features.Users.Commands.Mapping;

public partial class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<AddUserCommand, User>();
        CreateMap<EditUserCommand, User>();
    }
}
