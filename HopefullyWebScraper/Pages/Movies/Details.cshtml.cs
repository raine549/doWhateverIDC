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
    public class DetailsModel : PageModel
    {
        private readonly HopefullyWebScraper.Data.HopefullyWebScraperContext _context;

        public DetailsModel(HopefullyWebScraper.Data.HopefullyWebScraperContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
