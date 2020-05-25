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
                .ForMember(dest => dest.CountryPhotoMemories, opt => opt.MapFrom(src => src.Memories.Select(g => g.Memory)))
                .ForMember(dest => dest.Favourites, opt => opt.MapFrom(src => src.Favourites.Select(g => g.Favourite)))
                .ForMember(dest => dest.CountryWishlists, opt => opt.MapFrom(src => src.CountryWishlists.Select(g => g.Wishlist)))
                .ForMember(dest => dest.FlagUrl, opt => opt.MapFrom(src => src.Flag));
            CreateMap<CountryDto, Country>()

                .ForMember(dest => dest.Memories, opt => opt.MapFrom(src => src.CountryPhotoMemories.Select(g => new CountryPhotoMemories { CountryId = src.Id, MemoryId = g.Id })))
                .ForMember(dest => dest.Favourites, opt => opt.MapFrom(src => src.Favourites.Select(g => new CountryFavourites { CountryId = src.Id, FavouriteId = g.Id })))
                .ForMember(dest => dest.CountryWishlists, opt => opt.MapFrom(src => src.CountryWishlists.Select(g => new CountryWishlists { CountryId = src.Id, WishlistId = g.Id })))
                .ForMember(dest => dest.Flag, opt => opt.MapFrom(src => src.FlagUrl));
        }
    }
}
