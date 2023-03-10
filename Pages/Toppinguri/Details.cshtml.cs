using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cafenea.Data;
using Cafenea.Models;

namespace Cafenea.Pages.Toppinguri
{
    public class DetailsModel : PageModel
    {
        private readonly Cafenea.Data.CafeneaContext _context;

        public DetailsModel(Cafenea.Data.CafeneaContext context)
        {
            _context = context;
        }

      public Topping Topping { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Topping == null)
            {
                return NotFound();
            }

            var topping = await _context.Topping.FirstOrDefaultAsync(m => m.ID == id);
            if (topping == null)
            {
                return NotFound();
            }
            else 
            {
                Topping = topping;
            }
            return Page();
        }
    }
}
