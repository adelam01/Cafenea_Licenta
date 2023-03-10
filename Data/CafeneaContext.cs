using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cafenea.Models;

namespace Cafenea.Data
{
    public class CafeneaContext : DbContext
    {
        public CafeneaContext (DbContextOptions<CafeneaContext> options)
            : base(options)
        {
        }

        public DbSet<Cafenea.Models.Cafea> Cafea { get; set; } = default!;

        public DbSet<Cafenea.Models.Aroma> Aroma { get; set; }

        public DbSet<Cafenea.Models.Lapte> Lapte { get; set; }

        public DbSet<Cafenea.Models.TipCafea> TipCafea { get; set; }

        public DbSet<Cafenea.Models.Topping> Topping { get; set; }

        public DbSet<Cafenea.Models.TipBoabe> TipBoabe { get; set; }
    }
}
