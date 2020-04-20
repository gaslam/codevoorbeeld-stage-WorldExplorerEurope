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
                 .ForMember(dest => dest.PhotoMemories, opt => opt.MapFrom(src => src.Memories.Select(g => g.Memory)))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            CreateMap<PhotoMemoryDto, PhotoMemory>()
                .ForMember(dest => dest.Memories, opt => opt.MapFrom(src => src.PhotoMemories.Select(g => new CountryPhotoMemories { MemoryId = src.Id, CountryId = g.Id })))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            CreateMap<PhotoMemory, CountryPhotoMemories>()
                .ForMember(dest => dest.MemoryId, opt => opt.MapFrom(src => src.Id));


            CreateMap<CountryPhotoMemories, PhotoMemory>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.MemoryId));

        }
    }
}
