﻿using AutoMapper;
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

        private readonly WorldExplorerContext _worldExplorerContext;

        public CountryRepository(WorldExplorerContext worldExplorerContext, IMapper mapper) : base(worldExplorerContext, mapper)
        {
            _worldExplorerContext = worldExplorerContext;
        }
    }
}
