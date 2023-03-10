using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cafenea.Data;
using Cafenea.Models;

namespace Cafenea.Pages.Arome
{
    public class CreateModel : PageModel
    {
        private readonly Cafenea.Data.CafeneaContext _context;

        public CreateModel(Cafenea.Data.CafeneaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Aroma Aroma { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Aroma.Add(Aroma);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
