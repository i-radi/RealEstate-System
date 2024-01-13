using AutoMapper;
using Core.Features.Users.Queries.Results;
using Data.Entities;

namespace Core.Features.Users.Mapping;

public partial class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, GetUserByIdResponse>();
        CreateMap<User, GetUserPaginationReponse>();
    }
}
