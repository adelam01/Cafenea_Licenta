using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Cafenea.Models
{
    public class Cafea
    {
        public int ID { get; set; }

        [Display(Name = "Denumire cafea")]
        public string DenumireCafea { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal PretFinal { get; set; }

        //Cheie straina pentru cafea => CAMP OBLIGATORIU
        [Display(Name = "Tip cafea")]
        public int TipCafeaID { get; set; }
        public TipCafea TipCafea { get; set; }

        //Cheie straina pentru tipul de boabe => CAMP OBLIGATORIU
        public int TipBoabeID { get; set; }
        public TipBoabe TipBoabe { get; set; }

        //Cheie straina pentru lapte => OPTIONAL
        public int? LapteID { get; set; }
        public Lapte? Lapte { get; set; }

        //Cheie straina pentru lapte => OPTIONAL
        public int? AromaID { get; set; }
        public Aroma? Aroma { get; set; }

        //Cheie straina pentru lapte => OPTIONAL
        public int? ToppingID { get; set; }
        public Topping? Topping { get; set; }



    }
}
