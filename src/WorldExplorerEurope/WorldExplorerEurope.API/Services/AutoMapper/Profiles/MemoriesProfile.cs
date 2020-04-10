using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Services.AutoMapper.Profiles
{
    public class MemoriesProfile : Profile
    {
        public MemoriesProfile()
        {
            CreateMap<PhotoMemory, PhotoMemoryDto>()
                .ForMember(dest => dest.Memories, opt => opt.MapFrom(src => src.Memories));

            CreateMap<PhotoMemoryDto, PhotoMemory>()
                .ForMember(dest => dest.Memories, opt => opt.MapFrom(src => src.Memories));
        }
    }
}
