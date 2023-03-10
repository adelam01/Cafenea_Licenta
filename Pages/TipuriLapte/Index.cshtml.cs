using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cafenea.Data;
using Cafenea.Models;

namespace Cafenea.Pages.TipuriLapte
{
    public class IndexModel : PageModel
    {
        private readonly Cafenea.Data.CafeneaContext _context;

        public IndexModel(Cafenea.Data.CafeneaContext context)
        {
            _context = context;
        }

        public IList<Lapte> Lapte { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Lapte != null)
            {
                Lapte = await _context.Lapte.ToListAsync();
            }
        }
    }
}
