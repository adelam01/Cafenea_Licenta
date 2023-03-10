﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Cafenea.Data.CafeneaContext _context;

        public DetailsModel(Cafenea.Data.CafeneaContext context)
        {
            _context = context;
        }

      public TipCafea TipCafea { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TipCafea == null)
            {
                return NotFound();
            }

            var tipcafea = await _context.TipCafea.FirstOrDefaultAsync(m => m.ID == id);
            if (tipcafea == null)
            {
                return NotFound();
            }
            else 
            {
                TipCafea = tipcafea;
            }
            return Page();
        }
    }
}
