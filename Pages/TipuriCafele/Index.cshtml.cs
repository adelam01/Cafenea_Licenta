using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cafenea.Data;
using Cafenea.Models;

namespace Cafenea.Pages.TipuriCafele
{
    public class IndexModel : PageModel
    {
        private readonly Cafenea.Data.CafeneaContext _context;

        public IndexModel(Cafenea.Data.CafeneaContext context)
        {
            _context = context;
        }

        public IList<TipCafea> TipCafea { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.TipCafea != null)
            {
                TipCafea = await _context.TipCafea.ToListAsync();
            }
        }
    }
}
