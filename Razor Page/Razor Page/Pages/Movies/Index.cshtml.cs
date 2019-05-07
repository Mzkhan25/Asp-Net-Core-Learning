using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Page.Models;

namespace Razor_Page.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Razor_Page.Models.RazorPageContext _context;

        public IndexModel(Razor_Page.Models.RazorPageContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
