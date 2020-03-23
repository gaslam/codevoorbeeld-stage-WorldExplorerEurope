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
        public DbSet<User> Users { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<SpotifyPlaylist> SpotifyPlaylists { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMemories>().ToTable("UserMemories")
                .HasKey(m => new { m.UserId, m.MemoryId });

            modelBuilder.Entity<UserMemories>()
                .HasOne(m => m.User)
                .WithMany(m => m.Memories)
                .HasForeignKey(m => m.UserId);

            modelBuilder.Entity<UserMemories>()
                .HasOne(m => m.Memory)
                .WithMany(m => m.Memories)
                .HasForeignKey(m => m.MemoryId);

            modelBuilder.Entity<UserFavourites>().ToTable("UserFavourites")
                .HasKey(m => new { m.UserId, m.FavouriteId });

            modelBuilder.Entity<UserFavourites>()
                .HasOne(m => m.User)
                .WithMany(m => m.Favourites)
                .HasForeignKey(m => m.UserId);

            modelBuilder.Entity<UserFavourites>()
                .HasOne(m => m.Favourite)
                .WithMany(m => m.Favourites)
                .HasForeignKey(m => m.FavouriteId);

            modelBuilder.Entity<UserWishlists>()
                .HasOne(m => m.User)
                .WithMany(m => m.Wishlists)
                .HasForeignKey(m => m.UserId);

            modelBuilder.Entity<UserWishlists>()
                .HasOne(m => m.Wishlist)
                .WithMany(m => m.Wishlists)
                .HasForeignKey(m => m.WishlistId);


            var countries = _restcountriesService.GetCountryData();
            var descriptions = _wikipediaService.GetDescription(countries).Result;

            #region countries

            /*I chose to to it this way to make it easier
             * to find any mistakes
             */

            List<Guid> guids = new List<Guid>();
            foreach (var country in countries)
            {
                guids.Add(Guid.NewGuid());
            }

            modelBuilder.Entity<Country>()
                .ToTable("Countries")
                .HasData(
                new Country { Id = guids[0], Name = countries[0].name, Capital = countries[0].capital, Currency = countries[0].currencies[0].name, Description = descriptions[0].extract, Flag = new Uri(countries[0].flag), Population = countries[0].population, IsEUMember = true },
                new Country { Id = guids[1], Name = countries[1].name, Capital = countries[1].capital, Currency = countries[1].currencies[0].name, Description = descriptions[1].extract, Flag = new Uri(countries[1].flag), Population = countries[1].population, IsEUMember = true },
                new Country { Id = guids[2], Name = countries[2].name, Capital = countries[2].capital, Currency = countries[2].currencies[0].name, Description = descriptions[2].extract, Flag = new Uri(countries[2].flag), Population = countries[2].population, IsEUMember = true },
                new Country { Id = guids[3], Name = countries[3].name, Capital = countries[3].capital, Currency = countries[3].currencies[0].name, Description = descriptions[3].extract, Flag = new Uri(countries[3].flag), Population = countries[3].population, IsEUMember = true },
                new Country { Id = guids[4], Name = countries[4].name, Capital = countries[4].capital, Currency = countries[4].currencies[0].name, Description = descriptions[4].extract, Flag = new Uri(countries[4].flag), Population = countries[4].population, IsEUMember = true },
                new Country { Id = guids[5], Name = countries[5].name, Capital = countries[5].capital, Currency = countries[5].currencies[0].name, Description = descriptions[5].extract, Flag = new Uri(countries[5].flag), Population = countries[5].population, IsEUMember = true },
                new Country { Id = guids[6], Name = countries[6].name, Capital = countries[6].capital, Currency = countries[6].currencies[0].name, Description = descriptions[6].extract, Flag = new Uri(countries[6].flag), Population = countries[6].population, IsEUMember = true },
                new Country { Id = guids[7], Name = countries[7].name, Capital = countries[7].capital, Currency = countries[7].currencies[0].name, Description = descriptions[7].extract, Flag = new Uri(countries[7].flag), Population = countries[7].population, IsEUMember = true },
                new Country { Id = guids[8], Name = countries[8].name, Capital = countries[8].capital, Currency = countries[8].currencies[0].name, Description = descriptions[8].extract, Flag = new Uri(countries[8].flag), Population = countries[8].population, IsEUMember = true },
                new Country { Id = guids[9], Name = countries[9].name, Capital = countries[9].capital, Currency = countries[9].currencies[0].name, Description = descriptions[9].extract, Flag = new Uri(countries[9].flag), Population = countries[9].population, IsEUMember = true },
                new Country { Id = guids[10], Name = countries[10].name, Capital = countries[10].capital, Currency = countries[10].currencies[0].name, Description = descriptions[10].extract, Flag = new Uri(countries[10].flag), Population = countries[10].population, IsEUMember = true },
                new Country { Id = guids[11], Name = countries[11].name, Capital = countries[11].capital, Currency = countries[11].currencies[0].name, Description = descriptions[11].extract, Flag = new Uri(countries[11].flag), Population = countries[11].population, IsEUMember = true },
                new Country { Id = guids[12], Name = countries[12].name, Capital = countries[12].capital, Currency = countries[12].currencies[0].name, Description = descriptions[12].extract, Flag = new Uri(countries[12].flag), Population = countries[12].population, IsEUMember = true },
                new Country { Id = guids[13], Name = countries[13].name, Capital = countries[13].capital, Currency = countries[13].currencies[0].name, Description = descriptions[13].extract, Flag = new Uri(countries[13].flag), Population = countries[13].population, IsEUMember = true },
                new Country { Id = guids[14], Name = countries[14].name, Capital = countries[14].capital, Currency = countries[14].currencies[0].name, Description = descriptions[14].extract, Flag = new Uri(countries[14].flag), Population = countries[14].population, IsEUMember = true },
                new Country { Id = guids[15], Name = countries[15].name, Capital = countries[15].capital, Currency = countries[15].currencies[0].name, Description = descriptions[15].extract, Flag = new Uri(countries[15].flag), Population = countries[15].population, IsEUMember = true },
                new Country { Id = guids[16], Name = countries[16].name, Capital = countries[16].capital, Currency = countries[16].currencies[0].name, Description = descriptions[16].extract, Flag = new Uri(countries[16].flag), Population = countries[16].population, IsEUMember = true },
                new Country { Id = guids[17], Name = countries[17].name, Capital = countries[17].capital, Currency = countries[17].currencies[0].name, Description = descriptions[17].extract, Flag = new Uri(countries[17].flag), Population = countries[17].population, IsEUMember = true },
                new Country { Id = guids[18], Name = countries[18].name, Capital = countries[18].capital, Currency = countries[18].currencies[0].name, Description = descriptions[18].extract, Flag = new Uri(countries[18].flag), Population = countries[18].population, IsEUMember = true },
                new Country { Id = guids[19], Name = countries[19].name, Capital = countries[19].capital, Currency = countries[19].currencies[0].name, Description = descriptions[19].extract, Flag = new Uri(countries[19].flag), Population = countries[19].population, IsEUMember = true },
                new Country { Id = guids[20], Name = countries[20].name, Capital = countries[20].capital, Currency = countries[20].currencies[0].name, Description = descriptions[20].extract, Flag = new Uri(countries[20].flag), Population = countries[20].population, IsEUMember = true },
                new Country { Id = guids[21], Name = countries[21].name, Capital = countries[21].capital, Currency = countries[21].currencies[0].name, Description = descriptions[21].extract, Flag = new Uri(countries[21].flag), Population = countries[21].population, IsEUMember = true },
                new Country { Id = guids[22], Name = countries[22].name, Capital = countries[22].capital, Currency = countries[22].currencies[0].name, Description = descriptions[22].extract, Flag = new Uri(countries[22].flag), Population = countries[22].population, IsEUMember = true },
                new Country { Id = guids[23], Name = countries[23].name, Capital = countries[23].capital, Currency = countries[23].currencies[0].name, Description = descriptions[23].extract, Flag = new Uri(countries[23].flag), Population = countries[23].population, IsEUMember = true },
                new Country { Id = guids[24], Name = countries[24].name, Capital = countries[24].capital, Currency = countries[24].currencies[0].name, Description = descriptions[24].extract, Flag = new Uri(countries[24].flag), Population = countries[24].population, IsEUMember = true },
                new Country { Id = guids[25], Name = countries[25].name, Capital = countries[25].capital, Currency = countries[25].currencies[0].name, Description = descriptions[25].extract, Flag = new Uri(countries[25].flag), Population = countries[25].population, IsEUMember = true },
                new Country { Id = guids[26], Name = countries[26].name, Capital = countries[26].capital, Currency = countries[26].currencies[0].name, Description = descriptions[26].extract, Flag = new Uri(countries[26].flag), Population = countries[26].population, IsEUMember = true },
                new Country { Id = guids[27], Name = countries[27].name, Capital = countries[27].capital, Currency = countries[27].currencies[0].name, Description = descriptions[27].extract, Flag = new Uri(countries[27].flag), Population = countries[27].population, IsEUMember = true },
                new Country { Id = guids[28], Name = countries[28].name, Capital = countries[28].capital, Currency = countries[28].currencies[0].name, Description = descriptions[28].extract, Flag = new Uri(countries[28].flag), Population = countries[28].population, IsEUMember = true },
                new Country { Id = guids[29], Name = countries[29].name, Capital = countries[29].capital, Currency = countries[29].currencies[0].name, Description = descriptions[29].extract, Flag = new Uri(countries[29].flag), Population = countries[29].population, IsEUMember = true },
                new Country { Id = guids[30], Name = countries[30].name, Capital = countries[30].capital, Currency = countries[30].currencies[0].name, Description = descriptions[30].extract, Flag = new Uri(countries[30].flag), Population = countries[30].population, IsEUMember = true },
                new Country { Id = guids[31], Name = countries[31].name, Capital = countries[31].capital, Currency = countries[31].currencies[0].name, Description = descriptions[31].extract, Flag = new Uri(countries[31].flag), Population = countries[31].population, IsEUMember = true },
                new Country { Id = guids[32], Name = countries[32].name, Capital = countries[32].capital, Currency = countries[32].currencies[0].name, Description = descriptions[32].extract, Flag = new Uri(countries[32].flag), Population = countries[32].population, IsEUMember = true },
                new Country { Id = guids[33], Name = countries[33].name, Capital = countries[33].capital, Currency = countries[33].currencies[0].name, Description = descriptions[33].extract, Flag = new Uri(countries[33].flag), Population = countries[33].population, IsEUMember = true },
                new Country { Id = guids[34], Name = countries[34].name, Capital = countries[34].capital, Currency = countries[34].currencies[0].name, Description = descriptions[34].extract, Flag = new Uri(countries[34].flag), Population = countries[34].population, IsEUMember = true },
                new Country { Id = guids[35], Name = countries[35].name, Capital = countries[35].capital, Currency = countries[35].currencies[0].name, Description = descriptions[35].extract, Flag = new Uri(countries[35].flag), Population = countries[35].population, IsEUMember = true },
                new Country { Id = guids[36], Name = countries[36].name, Capital = countries[36].capital, Currency = countries[36].currencies[0].name, Description = descriptions[36].extract, Flag = new Uri(countries[36].flag), Population = countries[36].population, IsEUMember = true },
                new Country { Id = guids[37], Name = countries[37].name, Capital = countries[37].capital, Currency = countries[37].currencies[0].name, Description = descriptions[37].extract, Flag = new Uri(countries[37].flag), Population = countries[37].population, IsEUMember = true },
                new Country { Id = guids[38], Name = countries[38].name, Capital = countries[38].capital, Currency = countries[38].currencies[0].name, Description = descriptions[38].extract, Flag = new Uri(countries[38].flag), Population = countries[38].population, IsEUMember = true },
                new Country { Id = guids[39], Name = countries[39].name, Capital = countries[39].capital, Currency = countries[39].currencies[0].name, Description = descriptions[39].extract, Flag = new Uri(countries[39].flag), Population = countries[39].population, IsEUMember = true },
                new Country { Id = guids[40], Name = countries[40].name, Capital = countries[40].capital, Currency = countries[40].currencies[0].name, Description = descriptions[40].extract, Flag = new Uri(countries[40].flag), Population = countries[40].population, IsEUMember = true },
                new Country { Id = guids[41], Name = countries[41].name, Capital = countries[41].capital, Currency = countries[41].currencies[0].name, Description = descriptions[41].extract, Flag = new Uri(countries[41].flag), Population = countries[41].population, IsEUMember = true },
                new Country { Id = guids[42], Name = countries[42].name, Capital = countries[42].capital, Currency = countries[42].currencies[0].name, Description = descriptions[42].extract, Flag = new Uri(countries[42].flag), Population = countries[42].population, IsEUMember = true },
                new Country { Id = guids[43], Name = countries[43].name, Capital = countries[43].capital, Currency = countries[43].currencies[0].name, Description = descriptions[43].extract, Flag = new Uri(countries[43].flag), Population = countries[43].population, IsEUMember = true },
                new Country { Id = guids[44], Name = countries[44].name, Capital = countries[44].capital, Currency = countries[44].currencies[0].name, Description = descriptions[44].extract, Flag = new Uri(countries[44].flag), Population = countries[44].population, IsEUMember = true },
                new Country { Id = guids[45], Name = countries[45].name, Capital = countries[45].capital, Currency = countries[45].currencies[0].name, Description = descriptions[45].extract, Flag = new Uri(countries[45].flag), Population = countries[45].population, IsEUMember = true },
                new Country { Id = guids[46], Name = countries[46].name, Capital = countries[46].capital, Currency = countries[46].currencies[0].name, Description = descriptions[46].extract, Flag = new Uri(countries[46].flag), Population = countries[46].population, IsEUMember = true },
                new Country { Id = guids[47], Name = countries[47].name, Capital = countries[47].capital, Currency = countries[47].currencies[0].name, Description = descriptions[47].extract, Flag = new Uri(countries[47].flag), Population = countries[47].population, IsEUMember = true },
                new Country { Id = guids[48], Name = countries[48].name, Capital = countries[48].capital, Currency = countries[48].currencies[0].name, Description = descriptions[48].extract, Flag = new Uri(countries[48].flag), Population = countries[48].population, IsEUMember = true },
                new Country { Id = guids[49], Name = countries[49].name, Capital = countries[49].capital, Currency = countries[49].currencies[0].name, Description = descriptions[49].extract, Flag = new Uri(countries[49].flag), Population = countries[49].population, IsEUMember = true },
                new Country { Id = guids[50], Name = countries[50].name, Capital = countries[50].capital, Currency = countries[50].currencies[0].name, Description = descriptions[50].extract, Flag = new Uri(countries[50].flag), Population = countries[50].population, IsEUMember = true },
                new Country { Id = guids[51], Name = countries[51].name, Capital = countries[51].capital, Currency = countries[51].currencies[0].name, Description = descriptions[51].extract, Flag = new Uri(countries[51].flag), Population = countries[51].population, IsEUMember = true },
                new Country { Id = guids[52], Name = countries[52].name, Capital = countries[52].capital, Currency = countries[52].currencies[0].name, Description = descriptions[52].extract, Flag = new Uri(countries[52].flag), Population = countries[52].population, IsEUMember = true }
                );
            #endregion

            #region SpotifyPlaylists
            modelBuilder.Entity<SpotifyPlaylist>().ToTable("CountrySpotifyPlaylist")
                .HasData(
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[0], PlaylistId ="spotify:playlist:2CusBjVWAtRWy0L5BfmikW" }, //Åland_Islands
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[1], PlaylistId ="spotify:playlist:7l0CFkcQuUzGolpc36QMIC" }, //Albania
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[3], PlaylistId ="spotify:playlist:53lWeMXMoJ2wWUS1nYnBgl" }, //Austria
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[4], PlaylistId ="spotify:playlist:5Gu9Cbjqk2MAXo1yY09lCk" }, //Belarus
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[5], PlaylistId ="spotify:playlist:50AOO2iX1bfP12JDe2cSAN" }, //Belgium
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[7], PlaylistId ="spotify:playlist:6DpX8j1kTO55ZazVWIUJ9H" }, //Bulgaria
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[8], PlaylistId ="spotify:playlist:0LexRqlNAFHzIG3upGcA0S" }, //Croatia
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[9], PlaylistId = "spotify:playlist:2CusBjVWAtRWy0L5BfmikW" }, //Cyprus
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[10], PlaylistId ="spotify:playlist:253ARKQpYyLw3VYbIiy2zn" }, //Czech Republic
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[11], PlaylistId ="spotify:playlist:7nUxZrzOz1FS67LYqsjdIv" }, //Denmark
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[12], PlaylistId ="spotify:playlist:1ObBKzabSHf6WD4VZI8fJU" }, //Estonia
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[13], PlaylistId ="spotify:playlist:5EC6uJxihNWkD5ZlYXKpL5" }, //Faroe Islands
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[14], PlaylistId ="spotify:playlist:2CusBjVWAtRWy0L5BfmikW" }, //Finland
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[15], PlaylistId ="spotify:playlist:0QgtRvswo2Ugn0B1MTHQkW" }, //France
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[16], PlaylistId ="spotify:playlist:7Cdk1T18F4mJKNPJxmP8o3" }, //Germany
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[17], PlaylistId ="spotify:playlist:30EHPgCW4KRgOR4VumFHfs" }, //Gibraltar
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[18], PlaylistId ="spotify:playlist:1s8ckUBY7ZZjrJMPZ4BtOj" }, //Greece
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[21], PlaylistId ="spotify:playlist:7LsbwkqPWuIVjM8OmqJyJh" }, //I'm so Hungary
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[22], PlaylistId ="spotify:playlist:2dvjKJLYeizywy2NQiKlVO" }, //Iceland
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[23], PlaylistId ="spotify:playlist:2zesk6vpZhemqH9FbZKZnq" }, //Ireland
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[24], PlaylistId ="spotify:playlist:2zesk6vpZhemqH9FbZKZnq" }, //Isle of Man
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[25], PlaylistId ="spotify:playlist:0ylcsCmX0r03zT9yISmFWp" }, //Italy
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[29], PlaylistId ="spotify:playlist:12CfDHYf2nkZANtS9f9Vew" }, //Lithuania
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[30], PlaylistId ="spotify:playlist:09TxUze3BuYVNvMY6d418n" }, //Luxembourg
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[31], PlaylistId ="spotify:playlist:6wk61XRax6dMvX3WClLYbH" }, //Macedonia
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[33], PlaylistId ="spotify:playlist:3ZzdoANeDnNgpPDN8BdL59" }, //Moldova
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[34], PlaylistId ="spotify:playlist:3gl4XsDZjDEhP6ENWG0SSm" }, //Monaco
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[35], PlaylistId ="spotify:playlist:4AJvqhZvRE796GP9RYNrYc" }, //Montenegro
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[36], PlaylistId ="spotify:playlist:0FRAi3HnfdGT5Gn69MvYlT" }, //The Netherlands
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[37], PlaylistId ="spotify:playlist:6KgYE0tontk4mf54YQfXXS" }, //Norway
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[38], PlaylistId ="spotify:playlist:29XoM5S9Yc6Heflhp9fIoC" }, //Poland
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[39], PlaylistId ="spotify:playlist:5fpIpFlXUplr5Uy1J1qHnO" }, //Portugal
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[40], PlaylistId ="spotify:playlist:47dFbcLDn04CX7UorU8Iq8" }, //Republic of Kosovo
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[41], PlaylistId ="spotify:playlist:0g5twCr1C6oituq3La2Div" }, //Romania
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[42], PlaylistId ="spotify:playlist:6d3Zwzras2ghumJvnlIqsI" }, //Russia
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[43], PlaylistId ="spotify:playlist:7BSjWFXtpiJxdvzMSBl7Sq" }, //San Marino
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[44], PlaylistId ="spotify:playlist:1nN2hfHzcXNsVeGAwXev3s" }, //Serbia
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[45], PlaylistId ="spotify:playlist:65nrfnJcCxTLsyyjf8WCXe" }, //Slovakia
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[47], PlaylistId ="spotify:playlist:1irDloS9VCX40czYAS2klR" }, //Spain
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[48], PlaylistId ="spotify:playlist:6KgYE0tontk4mf54YQfXXS" }, //Svalbard And Jan Mayen
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[49], PlaylistId ="spotify:playlist:3BeBGfOciz2pHhmMYGF7Qq" }, //Sweden
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[50], PlaylistId ="spotify:playlist:7KCEnXSAo8e4aHkC3Barql" }, //Switzerland
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[51], PlaylistId ="spotify:playlist:5S1GVxkVbKXxoTV8DwBKGi" }, //Ukraine
                new SpotifyPlaylist { Id = Guid.NewGuid(), CountryId = guids[52], PlaylistId ="spotify:playlist:1y7E5GXSac77FzesM2ASjx" } //United Kingdom
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
