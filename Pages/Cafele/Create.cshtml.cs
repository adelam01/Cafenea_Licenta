using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cafenea.Data;
using Cafenea.Models;

namespace Cafenea.Pages.Cafele
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
            //Populare ViewBag pentru TIP CAFEA
            var listaTipCafea = _context.TipCafea.Select(x => new
            {
                x.ID,
                infoTipCafea = x.Tip + " - " + x.Pret.ToString() + " " + "RON"
            });
            ViewData["TipCafeaID"] = new SelectList(listaTipCafea, "ID", "infoTipCafea");

            //Populare ViewBag pentru TIP BOABE
            var listaTipBoabe = _context.TipBoabe.Select(x => new
            {
                x.ID,
                infoTipBoabe = x.DenumireBoabe + " - " + x.Pret.ToString() + " " + "RON"
            });
            ViewData["TipBoabeID"] = new SelectList(listaTipBoabe, "ID", "infoTipBoabe");

            //Populare ViewBag pentru LAPTE
            var listaTipLapte = _context.Lapte.Select(x => new
            {
                x.ID,
                infoTipLapte = x.DenumireLapte + " - " + x.Pret.ToString() + " " + "RON"    
            });
            ViewData["LapteID"] = new SelectList(listaTipLapte, "ID", "infoTipLapte");

            //Populare ViewBag pentru AROMA
            var listaTipAroma = _context.Aroma.Select(x => new
            {
                x.ID,
                infoTipAroma = x.DenumireAroma + " - " + x.Pret.ToString() + " " + "RON"
            });
            ViewData["AromaID"] = new SelectList(listaTipAroma, "ID", "infoTipAroma");

            //Populare ViewBag pentru TOPPING
            var listaTipTopping = _context.Topping.Select(x => new
            {
                x.ID,
                infoTipTopping = x.DenumireTopping + " - " + x.Pret.ToString() + " " + "RON"
            });
            ViewData["ToppingID"] = new SelectList(listaTipTopping, "ID", "infoTipTopping");



            return Page();

        }

        [BindProperty]
        public Cafea Cafea { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cafea.Add(Cafea);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
