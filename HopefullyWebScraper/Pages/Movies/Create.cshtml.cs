using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HopefullyWebScraper.Data;
using HopefullyWebScraper.Models;

namespace HopefullyWebScraper.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly HopefullyWebScraper.Data.HopefullyWebScraperContext _context;

        public CreateModel(HopefullyWebScraper.Data.HopefullyWebScraperContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
