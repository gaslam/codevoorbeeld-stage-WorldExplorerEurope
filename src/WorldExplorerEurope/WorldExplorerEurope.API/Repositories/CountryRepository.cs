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
            var countries = await _worldExplorerContext.CountryPhotoMemories.Where(m => m.CountryId == country.Id).ToListAsync();

            try
            {
                _worldExplorerContext.CountryPhotoMemories.RemoveRange(countries);
                await _worldExplorerContext.SaveChangesAsync();
                _worldExplorerContext.CountryPhotoMemories.AddRange(entity.Memories);
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
