using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cafenea.Data;
using Cafenea.Models;

namespace Cafenea.Pages.Boabe
{
    public class DetailsModel : PageModel
    {
        private readonly Cafenea.Data.CafeneaContext _context;

        public DetailsModel(Cafenea.Data.CafeneaContext context)
        {
            _context = context;
        }

      public TipBoabe TipBoabe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TipBoabe == null)
            {
                return NotFound();
            }

            var tipboabe = await _context.TipBoabe.FirstOrDefaultAsync(m => m.ID == id);
            if (tipboabe == null)
            {
                return NotFound();
            }
            else 
            {
                TipBoabe = tipboabe;
            }
            return Page();
        }
    }
}
