using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Domain.DTO;
using WorldExplorerEurope.API.Domain.Models;
using WorldExplorerEurope.API.Repositories.Base;

namespace WorldExplorerEurope.API.Repositories
{
    public class CountryRepository : MappingRepository<Country, CountryDto>
    {

        public CountryRepository(WorldExplorerContext worldExplorerContext, IMapper mapper) : base(worldExplorerContext, mapper)
        {
        }

        public override async Task<CountryDto> Update(CountryDto country)
        {
            var entity = _mapper.Map<Country>(country);
            _worldExplorerContext.Entry(entity).State = EntityState.Modified;
            var memories = await _worldExplorerContext.CountryPhotoMemories.Where(m => m.CountryId == country.Id).ToListAsync();
            var favourites = await _worldExplorerContext.CountryFavourites.Where(m => m.CountryId == country.Id).ToListAsync();
            var wishlists = await _worldExplorerContext.CountryWishlists.Where(m => m.CountryId == country.Id).ToListAsync();

            try
            {
                _worldExplorerContext.CountryPhotoMemories.RemoveRange(memories);
                await _worldExplorerContext.SaveChangesAsync();
                _worldExplorerContext.CountryWishlists.RemoveRange(wishlists);
                await _worldExplorerContext.SaveChangesAsync();
                _worldExplorerContext.CountryFavourites.RemoveRange(favourites);
                await _worldExplorerContext.SaveChangesAsync();
                _worldExplorerContext.CountryPhotoMemories.AddRange(entity.Memories);
                await _worldExplorerContext.SaveChangesAsync();
                _worldExplorerContext.CountryFavourites.AddRange(entity.Favourites);
                await _worldExplorerContext.SaveChangesAsync();
                _worldExplorerContext.CountryWishlists.AddRange(entity.CountryWishlists);
                await _worldExplorerContext.SaveChangesAsync();
            }
            catch
            {
                return null;
            }

            var newCountry = _mapper.Map<CountryDto>(entity);
            return newCountry;
        }
        
    }
}
