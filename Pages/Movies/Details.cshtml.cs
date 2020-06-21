using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Data;
using RazorPageMovie.Models;

namespace RazorPageMovie.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageMovie.Data.RazorPageMovieContext _context;

        public DetailsModel(RazorPageMovie.Data.RazorPageMovieContext context)
        {
            _context = context;
        }

        public Models.Movies Movies { get; set; }

        //Obsługuje @page "{id:int?} 
        //Bez ? przy int zostanie obsłużone domyślnie a OnGetAsync nie zostanie wywołane
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movies = await _context.Movies.FirstOrDefaultAsync(m => m.ID == id);

            if (Movies == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
