using AutoMapper;
using Core.Features.Properties.Queries.Results;
using Data.Entities.Properties;

namespace Core.Features.Properties.Mapping;

public partial class PropertyProfile : Profile
{
    public PropertyProfile()
    {
        CreateMap<Property, GetSinglePropertyResponse>()
            .ForMember(dest => dest.BrokerName, opt => opt.MapFrom(src => src.Broker.Localize(src.Broker.ListedByAr, src.Broker.ListedByEn)))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Localize(src.NameAr, src.NameEn)));

        CreateMap<Property, GetPropertyListResponse>()
            .ForMember(dest => dest.BrokerName, opt => opt.MapFrom(src => src.Broker.Localize(src.Broker.ListedByAr, src.Broker.ListedByEn)))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Localize(src.NameAr, src.NameEn)));

        CreateMap<Property, GetPropertyPaginatedListResponse>()
           .ForMember(dest => dest.BrokerName, opt => opt.MapFrom(src => src.Broker.Localize(src.Broker.ListedByAr, src.Broker.ListedByEn)))
           .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Localize(src.NameAr, src.NameEn)))
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
    }
}
