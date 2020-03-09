using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Domain;
using WorldExplorerEurope.API.Domain.Models;
using WorldExplorerEurope.API.Domain.Services;

namespace WorldExplorerEurope.API.Data
{
    public class WorldExplorerContext : DbContext
    {
        private readonly RestcountriesService _restcountriesService;
        private readonly WikipediaService _wikipediaService;

        public WorldExplorerContext(DbContextOptions<WorldExplorerContext>options) : base(options)
        {
            _restcountriesService = new RestcountriesService();
            _wikipediaService = new WikipediaService();
        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var countries = _restcountriesService.GetCountryData();
            var descriptions = _wikipediaService.GetDescription(countries).Result;

            modelBuilder.Entity<Country>()
                .ToTable("Countries")
                .HasData(
                new Country { Id = Guid.NewGuid(), Name = countries[0].name ,Capital = countries[0].capital, Currency = countries[0].currencies[0].name, Description = descriptions[0].extract, FlagUrl = countries[0].flag, Population = countries[0].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[1].name ,Capital = countries[1].capital, Currency = countries[1].currencies[0].name, Description = descriptions[1].extract, FlagUrl = countries[1].flag, Population = countries[1].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[2].name ,Capital = countries[2].capital, Currency = countries[2].currencies[0].name, Description = descriptions[2].extract, FlagUrl = countries[2].flag, Population = countries[2].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[3].name ,Capital = countries[3].capital, Currency = countries[3].currencies[0].name, Description = descriptions[3].extract, FlagUrl = countries[3].flag, Population = countries[3].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[4].name ,Capital = countries[4].capital, Currency = countries[4].currencies[0].name, Description = descriptions[4].extract, FlagUrl = countries[4].flag, Population = countries[4].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[5].name ,Capital = countries[5].capital, Currency = countries[5].currencies[0].name, Description = descriptions[5].extract, FlagUrl = countries[5].flag, Population = countries[5].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[6].name ,Capital = countries[6].capital, Currency = countries[6].currencies[0].name, Description = descriptions[6].extract, FlagUrl = countries[6].flag, Population = countries[6].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[7].name ,Capital = countries[7].capital, Currency = countries[7].currencies[0].name, Description = descriptions[7].extract, FlagUrl = countries[7].flag, Population = countries[7].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[8].name ,Capital = countries[8].capital, Currency = countries[8].currencies[0].name, Description = descriptions[8].extract, FlagUrl = countries[8].flag, Population = countries[8].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[9].name ,Capital = countries[9].capital, Currency = countries[9].currencies[0].name, Description = descriptions[9].extract, FlagUrl = countries[9].flag, Population = countries[9].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[10].name ,Capital = countries[10].capital, Currency = countries[10].currencies[0].name, Description = descriptions[10].extract, FlagUrl = countries[10].flag, Population = countries[10].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[11].name ,Capital = countries[11].capital, Currency = countries[11].currencies[0].name, Description = descriptions[11].extract, FlagUrl = countries[11].flag, Population = countries[11].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[12].name ,Capital = countries[12].capital, Currency = countries[12].currencies[0].name, Description = descriptions[12].extract, FlagUrl = countries[12].flag, Population = countries[12].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[13].name ,Capital = countries[13].capital, Currency = countries[13].currencies[0].name, Description = descriptions[13].extract, FlagUrl = countries[13].flag, Population = countries[13].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[14].name ,Capital = countries[14].capital, Currency = countries[14].currencies[0].name, Description = descriptions[14].extract, FlagUrl = countries[14].flag, Population = countries[14].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[15].name ,Capital = countries[15].capital, Currency = countries[15].currencies[0].name, Description = descriptions[15].extract, FlagUrl = countries[15].flag, Population = countries[15].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[16].name ,Capital = countries[16].capital, Currency = countries[16].currencies[0].name, Description = descriptions[16].extract, FlagUrl = countries[16].flag, Population = countries[16].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[17].name ,Capital = countries[17].capital, Currency = countries[17].currencies[0].name, Description = descriptions[17].extract, FlagUrl = countries[17].flag, Population = countries[17].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[18].name ,Capital = countries[18].capital, Currency = countries[18].currencies[0].name, Description = descriptions[18].extract, FlagUrl = countries[18].flag, Population = countries[18].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[19].name ,Capital = countries[19].capital, Currency = countries[19].currencies[0].name, Description = descriptions[19].extract, FlagUrl = countries[19].flag, Population = countries[19].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[20].name ,Capital = countries[20].capital, Currency = countries[20].currencies[0].name, Description = descriptions[20].extract, FlagUrl = countries[20].flag, Population = countries[20].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[21].name ,Capital = countries[21].capital, Currency = countries[21].currencies[0].name, Description = descriptions[21].extract, FlagUrl = countries[21].flag, Population = countries[21].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[22].name ,Capital = countries[22].capital, Currency = countries[22].currencies[0].name, Description = descriptions[22].extract, FlagUrl = countries[22].flag, Population = countries[22].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[23].name ,Capital = countries[23].capital, Currency = countries[23].currencies[0].name, Description = descriptions[23].extract, FlagUrl = countries[23].flag, Population = countries[23].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[24].name ,Capital = countries[24].capital, Currency = countries[24].currencies[0].name, Description = descriptions[24].extract, FlagUrl = countries[24].flag, Population = countries[24].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[25].name ,Capital = countries[25].capital, Currency = countries[25].currencies[0].name, Description = descriptions[25].extract, FlagUrl = countries[25].flag, Population = countries[25].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[26].name ,Capital = countries[26].capital, Currency = countries[26].currencies[0].name, Description = descriptions[26].extract, FlagUrl = countries[26].flag, Population = countries[26].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[27].name ,Capital = countries[27].capital, Currency = countries[27].currencies[0].name, Description = descriptions[27].extract, FlagUrl = countries[27].flag, Population = countries[27].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[28].name ,Capital = countries[28].capital, Currency = countries[28].currencies[0].name, Description = descriptions[28].extract, FlagUrl = countries[28].flag, Population = countries[28].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[29].name ,Capital = countries[29].capital, Currency = countries[29].currencies[0].name, Description = descriptions[29].extract, FlagUrl = countries[29].flag, Population = countries[29].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[30].name ,Capital = countries[30].capital, Currency = countries[30].currencies[0].name, Description = descriptions[30].extract, FlagUrl = countries[30].flag, Population = countries[30].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[31].name ,Capital = countries[31].capital, Currency = countries[31].currencies[0].name, Description = descriptions[31].extract, FlagUrl = countries[31].flag, Population = countries[31].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[32].name ,Capital = countries[32].capital, Currency = countries[32].currencies[0].name, Description = descriptions[32].extract, FlagUrl = countries[32].flag, Population = countries[32].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[33].name ,Capital = countries[33].capital, Currency = countries[33].currencies[0].name, Description = descriptions[33].extract, FlagUrl = countries[33].flag, Population = countries[33].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[34].name ,Capital = countries[34].capital, Currency = countries[34].currencies[0].name, Description = descriptions[34].extract, FlagUrl = countries[34].flag, Population = countries[34].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[35].name ,Capital = countries[35].capital, Currency = countries[35].currencies[0].name, Description = descriptions[35].extract, FlagUrl = countries[35].flag, Population = countries[35].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[36].name ,Capital = countries[36].capital, Currency = countries[36].currencies[0].name, Description = descriptions[36].extract, FlagUrl = countries[36].flag, Population = countries[36].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[37].name ,Capital = countries[37].capital, Currency = countries[37].currencies[0].name, Description = descriptions[37].extract, FlagUrl = countries[37].flag, Population = countries[37].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[38].name ,Capital = countries[38].capital, Currency = countries[38].currencies[0].name, Description = descriptions[38].extract, FlagUrl = countries[38].flag, Population = countries[38].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[39].name ,Capital = countries[39].capital, Currency = countries[39].currencies[0].name, Description = descriptions[39].extract, FlagUrl = countries[39].flag, Population = countries[39].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[40].name ,Capital = countries[40].capital, Currency = countries[40].currencies[0].name, Description = descriptions[40].extract, FlagUrl = countries[40].flag, Population = countries[40].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[41].name ,Capital = countries[41].capital, Currency = countries[41].currencies[0].name, Description = descriptions[41].extract, FlagUrl = countries[41].flag, Population = countries[41].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[42].name ,Capital = countries[42].capital, Currency = countries[42].currencies[0].name, Description = descriptions[42].extract, FlagUrl = countries[42].flag, Population = countries[42].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[43].name ,Capital = countries[43].capital, Currency = countries[43].currencies[0].name, Description = descriptions[43].extract, FlagUrl = countries[43].flag, Population = countries[43].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[44].name ,Capital = countries[44].capital, Currency = countries[44].currencies[0].name, Description = descriptions[44].extract, FlagUrl = countries[44].flag, Population = countries[44].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[45].name ,Capital = countries[45].capital, Currency = countries[45].currencies[0].name, Description = descriptions[45].extract, FlagUrl = countries[45].flag, Population = countries[45].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[46].name ,Capital = countries[46].capital, Currency = countries[46].currencies[0].name, Description = descriptions[46].extract, FlagUrl = countries[46].flag, Population = countries[46].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[47].name ,Capital = countries[47].capital, Currency = countries[47].currencies[0].name, Description = descriptions[47].extract, FlagUrl = countries[47].flag, Population = countries[47].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[48].name ,Capital = countries[48].capital, Currency = countries[48].currencies[0].name, Description = descriptions[48].extract, FlagUrl = countries[48].flag, Population = countries[48].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[49].name ,Capital = countries[49].capital, Currency = countries[49].currencies[0].name, Description = descriptions[49].extract, FlagUrl = countries[49].flag, Population = countries[49].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[50].name ,Capital = countries[50].capital, Currency = countries[50].currencies[0].name, Description = descriptions[50].extract, FlagUrl = countries[50].flag, Population = countries[50].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[51].name ,Capital = countries[51].capital, Currency = countries[51].currencies[0].name, Description = descriptions[51].extract, FlagUrl = countries[51].flag, Population = countries[51].population ,IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[52].name ,Capital = countries[52].capital, Currency = countries[52].currencies[0].name, Description = descriptions[52].extract, FlagUrl = countries[52].flag, Population = countries[52].population ,IsEUMember = true }
                );
        }
    }
}
