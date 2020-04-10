using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Services.AutoMapper.Profiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryDto>()
                .ForMember(dest => dest.FlagUrl, opt => opt.MapFrom(src => src.Flag))
                .ForMember(dest => dest.CountryPhotoMemories, opt => opt.MapFrom(src => src.PhotoMemories))
                .ForMember(dest => dest.Favourites, opt => opt.MapFrom(src => src.Favourites))
                .ForMember(dest => dest.CountryWishlists, opt => opt.MapFrom(src => src.CountryWishlists));
            CreateMap<CountryDto, Country>()
                .ForMember(dest => dest.Flag, opt => opt.MapFrom(src => src.FlagUrl))
                .ForMember(dest => dest.PhotoMemories, opt => opt.MapFrom(src => src.CountryPhotoMemories))
                .ForMember(dest => dest.Favourites, opt => opt.MapFrom(src => src.Favourites))
                .ForMember(dest => dest.CountryWishlists, opt => opt.MapFrom(src => src.CountryWishlists));
        }
    }
}
