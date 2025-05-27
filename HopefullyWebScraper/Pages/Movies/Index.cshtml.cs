﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HopefullyWebScraper.Data;
using HopefullyWebScraper.Models;

namespace HopefullyWebScraper.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly HopefullyWebScraper.Data.HopefullyWebScraperContext _context;

        public IndexModel(HopefullyWebScraper.Data.HopefullyWebScraperContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
