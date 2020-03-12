using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
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

        public WorldExplorerContext(DbContextOptions<WorldExplorerContext> options) : base(options)
        {
            _restcountriesService = new RestcountriesService();
            _wikipediaService = new WikipediaService();
        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserFavourites>().ToTable("UserMemories")
                .HasKey(m => new { m.UserId, m.MemoryId });

            modelBuilder.Entity<UserMemories>()
                .HasOne(m => m.User)
                .WithMany(m => m.Memories)
                .HasForeignKey(m => m.UserId);

            modelBuilder.Entity<UserMemories>()
                .HasOne(m => m.Memory)
                .WithMany(m => m.Memories)
                .HasForeignKey(m => m.MemoryId);

            var countries = _restcountriesService.GetCountryData();
            var descriptions = _wikipediaService.GetDescription(countries).Result;

            #region countries

            modelBuilder.Entity<Country>()
                .ToTable("Countries")
                .HasData(
                new Country { Id = Guid.NewGuid(), Name = countries[0].name, Capital = countries[0].capital, Currency = countries[0].currencies[0].name, Description = descriptions[0].extract, FlagUrl = countries[0].flag, Population = countries[0].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[1].name, Capital = countries[1].capital, Currency = countries[1].currencies[0].name, Description = descriptions[1].extract, FlagUrl = countries[1].flag, Population = countries[1].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[2].name, Capital = countries[2].capital, Currency = countries[2].currencies[0].name, Description = descriptions[2].extract, FlagUrl = countries[2].flag, Population = countries[2].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[3].name, Capital = countries[3].capital, Currency = countries[3].currencies[0].name, Description = descriptions[3].extract, FlagUrl = countries[3].flag, Population = countries[3].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[4].name, Capital = countries[4].capital, Currency = countries[4].currencies[0].name, Description = descriptions[4].extract, FlagUrl = countries[4].flag, Population = countries[4].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[5].name, Capital = countries[5].capital, Currency = countries[5].currencies[0].name, Description = descriptions[5].extract, FlagUrl = countries[5].flag, Population = countries[5].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[6].name, Capital = countries[6].capital, Currency = countries[6].currencies[0].name, Description = descriptions[6].extract, FlagUrl = countries[6].flag, Population = countries[6].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[7].name, Capital = countries[7].capital, Currency = countries[7].currencies[0].name, Description = descriptions[7].extract, FlagUrl = countries[7].flag, Population = countries[7].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[8].name, Capital = countries[8].capital, Currency = countries[8].currencies[0].name, Description = descriptions[8].extract, FlagUrl = countries[8].flag, Population = countries[8].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[9].name, Capital = countries[9].capital, Currency = countries[9].currencies[0].name, Description = descriptions[9].extract, FlagUrl = countries[9].flag, Population = countries[9].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[10].name, Capital = countries[10].capital, Currency = countries[10].currencies[0].name, Description = descriptions[10].extract, FlagUrl = countries[10].flag, Population = countries[10].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[11].name, Capital = countries[11].capital, Currency = countries[11].currencies[0].name, Description = descriptions[11].extract, FlagUrl = countries[11].flag, Population = countries[11].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[12].name, Capital = countries[12].capital, Currency = countries[12].currencies[0].name, Description = descriptions[12].extract, FlagUrl = countries[12].flag, Population = countries[12].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[13].name, Capital = countries[13].capital, Currency = countries[13].currencies[0].name, Description = descriptions[13].extract, FlagUrl = countries[13].flag, Population = countries[13].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[14].name, Capital = countries[14].capital, Currency = countries[14].currencies[0].name, Description = descriptions[14].extract, FlagUrl = countries[14].flag, Population = countries[14].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[15].name, Capital = countries[15].capital, Currency = countries[15].currencies[0].name, Description = descriptions[15].extract, FlagUrl = countries[15].flag, Population = countries[15].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[16].name, Capital = countries[16].capital, Currency = countries[16].currencies[0].name, Description = descriptions[16].extract, FlagUrl = countries[16].flag, Population = countries[16].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[17].name, Capital = countries[17].capital, Currency = countries[17].currencies[0].name, Description = descriptions[17].extract, FlagUrl = countries[17].flag, Population = countries[17].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[18].name, Capital = countries[18].capital, Currency = countries[18].currencies[0].name, Description = descriptions[18].extract, FlagUrl = countries[18].flag, Population = countries[18].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[19].name, Capital = countries[19].capital, Currency = countries[19].currencies[0].name, Description = descriptions[19].extract, FlagUrl = countries[19].flag, Population = countries[19].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[20].name, Capital = countries[20].capital, Currency = countries[20].currencies[0].name, Description = descriptions[20].extract, FlagUrl = countries[20].flag, Population = countries[20].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[21].name, Capital = countries[21].capital, Currency = countries[21].currencies[0].name, Description = descriptions[21].extract, FlagUrl = countries[21].flag, Population = countries[21].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[22].name, Capital = countries[22].capital, Currency = countries[22].currencies[0].name, Description = descriptions[22].extract, FlagUrl = countries[22].flag, Population = countries[22].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[23].name, Capital = countries[23].capital, Currency = countries[23].currencies[0].name, Description = descriptions[23].extract, FlagUrl = countries[23].flag, Population = countries[23].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[24].name, Capital = countries[24].capital, Currency = countries[24].currencies[0].name, Description = descriptions[24].extract, FlagUrl = countries[24].flag, Population = countries[24].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[25].name, Capital = countries[25].capital, Currency = countries[25].currencies[0].name, Description = descriptions[25].extract, FlagUrl = countries[25].flag, Population = countries[25].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[26].name, Capital = countries[26].capital, Currency = countries[26].currencies[0].name, Description = descriptions[26].extract, FlagUrl = countries[26].flag, Population = countries[26].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[27].name, Capital = countries[27].capital, Currency = countries[27].currencies[0].name, Description = descriptions[27].extract, FlagUrl = countries[27].flag, Population = countries[27].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[28].name, Capital = countries[28].capital, Currency = countries[28].currencies[0].name, Description = descriptions[28].extract, FlagUrl = countries[28].flag, Population = countries[28].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[29].name, Capital = countries[29].capital, Currency = countries[29].currencies[0].name, Description = descriptions[29].extract, FlagUrl = countries[29].flag, Population = countries[29].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[30].name, Capital = countries[30].capital, Currency = countries[30].currencies[0].name, Description = descriptions[30].extract, FlagUrl = countries[30].flag, Population = countries[30].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[31].name, Capital = countries[31].capital, Currency = countries[31].currencies[0].name, Description = descriptions[31].extract, FlagUrl = countries[31].flag, Population = countries[31].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[32].name, Capital = countries[32].capital, Currency = countries[32].currencies[0].name, Description = descriptions[32].extract, FlagUrl = countries[32].flag, Population = countries[32].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[33].name, Capital = countries[33].capital, Currency = countries[33].currencies[0].name, Description = descriptions[33].extract, FlagUrl = countries[33].flag, Population = countries[33].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[34].name, Capital = countries[34].capital, Currency = countries[34].currencies[0].name, Description = descriptions[34].extract, FlagUrl = countries[34].flag, Population = countries[34].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[35].name, Capital = countries[35].capital, Currency = countries[35].currencies[0].name, Description = descriptions[35].extract, FlagUrl = countries[35].flag, Population = countries[35].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[36].name, Capital = countries[36].capital, Currency = countries[36].currencies[0].name, Description = descriptions[36].extract, FlagUrl = countries[36].flag, Population = countries[36].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[37].name, Capital = countries[37].capital, Currency = countries[37].currencies[0].name, Description = descriptions[37].extract, FlagUrl = countries[37].flag, Population = countries[37].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[38].name, Capital = countries[38].capital, Currency = countries[38].currencies[0].name, Description = descriptions[38].extract, FlagUrl = countries[38].flag, Population = countries[38].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[39].name, Capital = countries[39].capital, Currency = countries[39].currencies[0].name, Description = descriptions[39].extract, FlagUrl = countries[39].flag, Population = countries[39].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[40].name, Capital = countries[40].capital, Currency = countries[40].currencies[0].name, Description = descriptions[40].extract, FlagUrl = countries[40].flag, Population = countries[40].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[41].name, Capital = countries[41].capital, Currency = countries[41].currencies[0].name, Description = descriptions[41].extract, FlagUrl = countries[41].flag, Population = countries[41].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[42].name, Capital = countries[42].capital, Currency = countries[42].currencies[0].name, Description = descriptions[42].extract, FlagUrl = countries[42].flag, Population = countries[42].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[43].name, Capital = countries[43].capital, Currency = countries[43].currencies[0].name, Description = descriptions[43].extract, FlagUrl = countries[43].flag, Population = countries[43].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[44].name, Capital = countries[44].capital, Currency = countries[44].currencies[0].name, Description = descriptions[44].extract, FlagUrl = countries[44].flag, Population = countries[44].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[45].name, Capital = countries[45].capital, Currency = countries[45].currencies[0].name, Description = descriptions[45].extract, FlagUrl = countries[45].flag, Population = countries[45].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[46].name, Capital = countries[46].capital, Currency = countries[46].currencies[0].name, Description = descriptions[46].extract, FlagUrl = countries[46].flag, Population = countries[46].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[47].name, Capital = countries[47].capital, Currency = countries[47].currencies[0].name, Description = descriptions[47].extract, FlagUrl = countries[47].flag, Population = countries[47].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[48].name, Capital = countries[48].capital, Currency = countries[48].currencies[0].name, Description = descriptions[48].extract, FlagUrl = countries[48].flag, Population = countries[48].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[49].name, Capital = countries[49].capital, Currency = countries[49].currencies[0].name, Description = descriptions[49].extract, FlagUrl = countries[49].flag, Population = countries[49].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[50].name, Capital = countries[50].capital, Currency = countries[50].currencies[0].name, Description = descriptions[50].extract, FlagUrl = countries[50].flag, Population = countries[50].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[51].name, Capital = countries[51].capital, Currency = countries[51].currencies[0].name, Description = descriptions[51].extract, FlagUrl = countries[51].flag, Population = countries[51].population, IsEUMember = true },
                new Country { Id = Guid.NewGuid(), Name = countries[52].name, Capital = countries[52].capital, Currency = countries[52].currencies[0].name, Description = descriptions[52].extract, FlagUrl = countries[52].flag, Population = countries[52].population, IsEUMember = true }
                );
            #endregion

            #region SpotifyPlaylists
            modelBuilder.Entity<SpotifyPlaylist>().ToTable("CountrySpotifyPlaylist")
                .HasData(
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("a9ab3ece-f1ad-489b-aa00-74d7a246ea6c"), PlaylistId = "2CusBjVWAtRWy0L5BfmikW" }, //Åland_Islands
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("f3b21c5b-738b-43e3-b52d-9d25f5c72830"), PlaylistId = "7l0CFkcQuUzGolpc36QMIC" }, //Albania
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("fe801777-d64c-441e-8519-1dbae8dc6fb2"), PlaylistId = "53lWeMXMoJ2wWUS1nYnBgl" }, //Austria
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("71b37ccd-b94f-427e-a020-5bf220e3dc80"), PlaylistId = "5Gu9Cbjqk2MAXo1yY09lCk" }, //Belarus
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("046b315a-650d-4e3b-b529-fecae5b87a9a"), PlaylistId = "50AOO2iX1bfP12JDe2cSAN" }, //Belgium
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("05359d2e-f758-419c-94f6-5e5cc9d20eea"), PlaylistId = "6DpX8j1kTO55ZazVWIUJ9H" }, //Bulgaria
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("0fa40f05-c9bc-495f-b34f-758128b89738"), PlaylistId = "0LexRqlNAFHzIG3upGcA0S" }, //Croatia
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("1edcf9d6-00c1-4089-9d2c-e1beb97bbab6"), PlaylistId = "0T73gC6LcZuhHfxuhTUSd5" }, //Cyprus
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("b72facb9-c554-429b-8220-0eb0b77cfba5"), PlaylistId = "253ARKQpYyLw3VYbIiy2zn" }, //Czech Republic
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("33ad3632-84aa-4237-a85a-8327054d2e4e"), PlaylistId = "7nUxZrzOz1FS67LYqsjdIv" }, //Denmark
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("2bc89329-9ea0-4fff-8f8d-eaff160aa0f4"), PlaylistId = "1ObBKzabSHf6WD4VZI8fJU" }, //Estonia
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("ab0c2222-cc54-43db-b4f9-a4a435165b0b"), PlaylistId = "5EC6uJxihNWkD5ZlYXKpL5" }, //Faroe Islands
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("699ee9c0-7809-4cb2-bc9e-bb93c42eec27"), PlaylistId = "2CusBjVWAtRWy0L5BfmikW" }, //Finland
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("8e7a4ca7-5969-4fe9-92a9-c5b0e84615fa"), PlaylistId = "0QgtRvswo2Ugn0B1MTHQkW" }, //France
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("7e6195b2-b6e0-4aa9-99d4-d5828178957f"), PlaylistId = "7Cdk1T18F4mJKNPJxmP8o3" }, //Germany
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("267c21b3-1196-4d63-ae68-cda8d46a5770"), PlaylistId = "30EHPgCW4KRgOR4VumFHfs" }, //Gibraltar
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("14ee21ae-860b-44c3-81eb-18c2c9029d6e"), PlaylistId = "1s8ckUBY7ZZjrJMPZ4BtOj" }, //Greece
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("7ccf94ca-815e-48d0-b129-531537fafd48"), PlaylistId = "7LsbwkqPWuIVjM8OmqJyJh" }, //I'm so Hungary
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("7445c62f-598f-4a2a-96b6-0e4f0b270663"), PlaylistId = "2dvjKJLYeizywy2NQiKlVO" }, //Iceland
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("456665d4-08ae-4af0-8de5-1eefa1b731ed"), PlaylistId = "2zesk6vpZhemqH9FbZKZnq" }, //Ireland
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("976986fa-3fdc-4055-8b75-514c47cbf368"), PlaylistId = "2zesk6vpZhemqH9FbZKZnq" }, //Isle of Man
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("96950426-e8ef-4b53-8ace-47409338ae34"), PlaylistId = "0ylcsCmX0r03zT9yISmFWp" }, //Italy
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("b4d58efb-fec5-4fd9-ad5d-511fee5dd696"), PlaylistId = "12CfDHYf2nkZANtS9f9Vew" }, //Lithuania
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("d334cbf6-c9c0-4e6c-9798-29b18fe6d7dc"), PlaylistId = "09TxUze3BuYVNvMY6d418n" }, //Luxembourg
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("8331777c-6ad7-4709-927e-2cc9a552df33"), PlaylistId = "6wk61XRax6dMvX3WClLYbH" }, //Macedonia
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("226da6e2-5ecd-42ae-a76e-e1f1e0620443"), PlaylistId = "3ZzdoANeDnNgpPDN8BdL59" }, //Moldova
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("4bd28c4f-b1e5-48db-962e-c4846a2bab25"), PlaylistId = "3gl4XsDZjDEhP6ENWG0SSm" }, //Monaco
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("a42c7880-7aa4-4a93-9132-3c6baf71a463"), PlaylistId = "4AJvqhZvRE796GP9RYNrYc" }, //Montenegro
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("09e4d5f8-d7f7-46b9-9ebd-d4fed276bc59"), PlaylistId = "0FRAi3HnfdGT5Gn69MvYlT" }, //The Netherlands
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("980290d4-a444-4cbc-aa5f-3f35c4a5b3ce"), PlaylistId = "6KgYE0tontk4mf54YQfXXS" }, //Norway
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("c016b71b-876d-4d0c-a4e4-3a971f11d4e7"), PlaylistId = "29XoM5S9Yc6Heflhp9fIoC" }, //Poland
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("4f3ab9de-a65d-4af7-8749-889589d4a8dc"), PlaylistId = "5fpIpFlXUplr5Uy1J1qHnO" }, //Portugal
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("e58424cb-6b13-4d15-b864-2292686308a4"), PlaylistId = "47dFbcLDn04CX7UorU8Iq8" }, //Republic of Kosovo
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("32eb469b-f61c-4837-baca-656260880a9a"), PlaylistId = "0g5twCr1C6oituq3La2Div" }, //Romania
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("00fa0142-c254-42a2-9854-4d5aa861e140"), PlaylistId = "6d3Zwzras2ghumJvnlIqsI" }, //Russia
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("8b1b6290-4501-430c-87f6-cdac63859869"), PlaylistId = "7BSjWFXtpiJxdvzMSBl7Sq" }, //San Marino
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("a3d58ada-1e36-4ce4-8f11-68abb778b594"), PlaylistId = "1nN2hfHzcXNsVeGAwXev3s" }, //Serbia
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("436c085f-529b-4505-845f-69058fc32c43"), PlaylistId = "65nrfnJcCxTLsyyjf8WCXe" }, //Slovakia
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("55e95bed-8e84-415f-abc8-cfa397cae592"), PlaylistId = "1irDloS9VCX40czYAS2klR" }, //Spain
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("c5ae435a-618a-4011-a0b2-9bd1ab198891"), PlaylistId = "6KgYE0tontk4mf54YQfXXS" }, //Svalbard And Jan Mayen
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("f60d4618-c8f3-4bbc-a042-e6aaf62d8e07"), PlaylistId = "3BeBGfOciz2pHhmMYGF7Qq" }, //Sweden
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("f07ab037-20c6-4050-a871-d85caeea2e86"), PlaylistId = "7KCEnXSAo8e4aHkC3Barql" }, //Switzerland
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("5adffe0f-9d91-4bcf-a638-eaafa0f36e5c"), PlaylistId = "5S1GVxkVbKXxoTV8DwBKGi" }, //Ukraine
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = Guid.Parse("9412b49f-062d-46a1-bf54-9e7935715745"), PlaylistId = "1y7E5GXSac77FzesM2ASjx" } //United Kingdom
                );
            #endregion

            var hasher = new PasswordHasher<User>();

            User user = new User
            {
                Id = Guid.Parse("a5311214-564f-4824-ba65-b57042349e49"),
                FirstName = "Gaspard",
                LastName = "Lammertyn",
                BirthDate = Convert.ToDateTime("12/05/1998"),
                Email = "gaspard.lammertyn@student.howest.be",
                Nationality = "Belgium",
                IsAdmin = true
            };
            user.Password = hasher.HashPassword(user, "t}F87)8GBaj<");

            modelBuilder.Entity<User>().ToTable("Users")
                .HasData(
                    user
                );

        }
    }
}
