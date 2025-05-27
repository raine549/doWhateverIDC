using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HopefullyWebScraper.Models;

namespace HopefullyWebScraper.Data
{
    public class HopefullyWebScraperContext : DbContext
    {
        public HopefullyWebScraperContext (DbContextOptions<HopefullyWebScraperContext> options)
            : base(options)
        {
        }

        public DbSet<HopefullyWebScraper.Models.Movie> Movie { get; set; } = default!;
    }
}

//creates a DBSet<Movie> property for the entity set
