using AutoMapper;
using Core.Bases;
using Data.Entities.Properties;

namespace Core.Features.Properties.Queries.Results;

public class GetPropertyListResponse : ICustomMapping
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? BrokerName { get; set; }

    public void CreateMappings(Profile configuration)
    {
        configuration.CreateMap<Property, GetPropertyListResponse>()
                    .ForMember(dest => dest.BrokerName, opt => opt.MapFrom(src => src.Broker.Localize(src.Broker.ListedByAr, src.Broker.ListedByEn)))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Localize(src.NameAr, src.NameEn)));
    }
}
