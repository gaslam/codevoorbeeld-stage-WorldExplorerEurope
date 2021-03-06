﻿using System;
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
using WorldExplorerEurope.API.Domain.Services;
using WorldExplorerEurope.API.Services;
using Microsoft.AspNetCore.Http;
using WorldExplorerEurope.API.Domain.Helpers;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using WorldExplorerEurope.API.Hubs;
using Microsoft.AspNetCore.Identity;

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
            services.AddDbContext<WorldExplorerContext>(options => options
                .UseSqlServer(Configuration.GetConnectionString("WorldExplorerService")));

            var settings = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(settings);

            var appSettings = settings.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddAutoMapper(typeof(Startup));

            services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<WorldExplorerContext>()
    .AddDefaultTokenProviders();

            services.AddScoped<IRepository<Country>, CountryRepository>();
            services.AddScoped<IMappingRepository<CountryDto>, CountryRepository>();
            services.AddScoped<IRepository<SpotifyPlaylist>, SpotifyRepository>();
            services.AddScoped<IMappingRepository<SpotifyPlaylistDto>, SpotifyRepository>();
            services.AddScoped<IMemoryPhotoService, MemoryService<Country>>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddScoped<IUserService, UserService>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WorldExplorer API", Version = "v1" });
            });
            services.AddCors();
            services.AddSignalR();

            services.AddAuthorization(options => options.AddPolicy("Admin", policy =>
                                {
                                    policy.RequireClaim("role", "Admin");
                                }));
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

            app.UseAuthentication();
            app.UseRouting();
            app.UseCors(builder => builder.AllowAnyOrigin()
.AllowAnyHeader()
.AllowAnyMethod());

            app.UseStaticFiles();

            //app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<ExplorerHub>("/ExplorerHub");
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "WorldExplorer API");
                c.RoutePrefix = string.Empty;
            });

            /*app.UseSignalR(routes =>
            {
                routes.MapHub<ExplorerHub>("/ExplorerHub");
            });*/
        }
    }
}
