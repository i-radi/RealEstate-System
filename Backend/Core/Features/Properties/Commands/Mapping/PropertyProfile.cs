using AutoMapper;
using Core.Features.Properties.Commands.Models;
using Data.Entities.Properties;

namespace Core.Features.Properties.Commands.Mapping;

public partial class PropertyProfile : Profile
{
    public PropertyProfile()
    {
        CreateMap<AddPropertyCommand, Property>()
           .ForMember(dest => dest.BrokerId, opt => opt.MapFrom(src => src.BrokerId))
           .ForMember(dest => dest.NameEn, opt => opt.MapFrom(src => src.NameEn))
           .ForMember(dest => dest.NameAr, opt => opt.MapFrom(src => src.NameAr));

        CreateMap<EditPropertyCommand, Property>()
           .ForMember(dest => dest.BrokerId, opt => opt.MapFrom(src => src.BrokerId))
           .ForMember(dest => dest.NameEn, opt => opt.MapFrom(src => src.NameEn))
           .ForMember(dest => dest.NameAr, opt => opt.MapFrom(src => src.NameAr));
    }
}
