using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WorldExplorerEurope.API.Data;
using WorldExplorerEurope.API.Repositories;
using WorldExplorerEurope.API.Domain.Interfaces;
using WorldExplorerEurope.API.Domain.Models;
using WorldExplorerEurope.API.Domain.DTO;
using Microsoft.OpenApi.Models;

namespace WorldExplorerEurope.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<WorldExplorerContext>(options => options
                .UseSqlServer(Configuration.GetConnectionString("WorldExplorerService")));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IRepository<User>, UserRepository>();
            services.AddScoped<IMappingRepository<UserDto>, UserRepository>();
            services.AddScoped<IRepository<Country>, CountryRepository>();
            services.AddScoped<IMappingRepository<CountryDto>, CountryRepository>();
            services.AddScoped<IRepository<SpotifyPlaylist>, SpotifyRepository>();
            services.AddScoped<IMappingRepository<SpotifyPlaylistDto>, SpotifyRepository>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WorldExplorer API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            endpoints.MapControllers());

            //app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "WorldExplorer API");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
