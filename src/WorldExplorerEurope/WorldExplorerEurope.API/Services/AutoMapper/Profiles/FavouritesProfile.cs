using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Services.AutoMapper.Profiles
{
    public class FavouritesProfile : Profile
    {
        public FavouritesProfile()
        {
            CreateMap<Favourite, FavouritesDto>()
                .ForMember(dest => dest.Favourites, opt => opt.MapFrom(src => src.Favourites));

            CreateMap<FavouritesDto, Favourite>()
                .ForMember(dest => dest.Favourites, opt => opt.MapFrom(src => src.Favourites));
        }
    }
}
