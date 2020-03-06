using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldExplorerEurope.API.Domain;
using WorldExplorerEurope.API.Domain.Models;

namespace WorldExplorerEurope.API.Data
{
    public class WorldExplorerContext : DbContext
    {
        public WorldExplorerContext(DbContextOptions<WorldExplorerContext>options) : base(options)
        {

        }

        public DbSet<Country> MyProperty { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
