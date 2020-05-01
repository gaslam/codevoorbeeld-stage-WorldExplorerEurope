using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Services.AutoMapper.Profiles
{
    public class WishlistsProfile : Profile
    {
        public WishlistsProfile()
        {
            CreateMap<Wishlist, WishlistDto>()
                .ForMember(dest => dest.Wishlists, opt => opt.MapFrom(src => src.Wishlists.Select(g => g.Wishlist)));

            CreateMap<WishlistDto, Wishlist>()
                .ForMember(dest => dest.Wishlists, opt => opt.MapFrom(src => src.Wishlists.Select(g => new CountryWishlists { WishlistId = src.Id, CountryId = g.Id })));

            CreateMap<WishlistDto, CountryWishlists>()
                .ForMember(dest => dest.WishlistId, opt => opt.MapFrom(src => src.Id));

            CreateMap<CountryWishlists, WishlistDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.WishlistId));
        }
    }
}
