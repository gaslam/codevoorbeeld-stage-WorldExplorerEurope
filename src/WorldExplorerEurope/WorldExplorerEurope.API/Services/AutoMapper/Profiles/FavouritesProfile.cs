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
                .ForMember(dest => dest.Favourites, opt => opt.MapFrom(src => src.Favourites.Select(g => g.Favourite)));

            CreateMap<FavouritesDto, Favourite>()
                .ForMember(dest => dest.Favourites, opt => opt.MapFrom(src => src.Favourites.Select(g => new CountryFavourites {  FavouriteId = src.Id, CountryId = g.Id})));

            CreateMap<FavouritesDto, CountryFavourites>()
                .ForMember(dest => dest.FavouriteId, opt => opt.MapFrom(src => src.Id));

            CreateMap<CountryFavourites, FavouritesDto>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.FavouriteId));
        }
    }
}
