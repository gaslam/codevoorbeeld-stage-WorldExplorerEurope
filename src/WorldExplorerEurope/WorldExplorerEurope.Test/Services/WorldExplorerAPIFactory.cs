using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using WorldExplorerEurope.API;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Services.AutoMapper.Profiles;

namespace WorldExplorerEurope.Test.Services
{
    public class WorldExplorerAPIFactory<T>: WebApplicationFactory<Startup>
    {
        //Ik heb het proberen anders te doen, maar het enige voorbeeld dat ik vond kwam uit ons project voor Workplace Experience. Ik zal zeker kijken of er bepaalde dingen hieruit onnodig zijn.
        private void ConfigureWebhost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var description = services.SingleOrDefault(m => m.ServiceType == typeof(DbContextOptions<WorldExplorerContext>));
                if(description != null)
                {
                    services.Remove(description);
                }

                var serviceProvider = new ServiceCollection()
                                    .AddEntityFrameworkInMemoryDatabase()
                                    .BuildServiceProvider();

                services.AddDbContext<WorldExplorerContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryWorldExplorerTest");
                    options.UseInternalServiceProvider(serviceProvider);
                });

                var provider = services.BuildServiceProvider();
                using(var sp = provider.CreateScope())
                {
                    using(var app = sp.ServiceProvider.GetRequiredService<WorldExplorerContext>())
                    {
                        try
                        {
                            app.Database.EnsureCreated();
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            );
        }
        public IMapper CreateMapper()
        {
            var configuration = new MapperConfiguration(config =>
            {
                config.AddProfile<CountryProfile>();
                config.AddProfile<FavouritesProfile>();
                config.AddProfile<MemoriesProfile>();
                config.AddProfile<SpotifyPlaylistsProfile>();
                config.AddProfile<UserProfile>();
                config.AddProfile<WishlistsProfile>();
            });

            return configuration.CreateMapper();
        }
    }
}
