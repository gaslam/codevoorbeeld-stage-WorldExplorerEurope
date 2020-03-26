using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Services.AutoMapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Memories, opt => opt.MapFrom(src => src.Memories))
                .ForMember(dest => dest.Favourites, opt => opt.MapFrom(src => src.Favourites));

            CreateMap<UserDto, User>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Memories, opt => opt.MapFrom(src => src.Memories))
                .ForMember(dest => dest.Favourites, opt => opt.MapFrom(src => src.Favourites));
        }
    }
}
