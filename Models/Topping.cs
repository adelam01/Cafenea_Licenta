using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Cafenea.Models
{
    public class Topping
    {
        public int ID { get; set; }

        [Display(Name = "Denumire topping")]
        public string DenumireTopping { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Pret { get; set; }

        //O sa contina in mod obligatoriu referinta catre mai multe cafele
        public ICollection<Cafea>? Cafele { get; set; }
    }
}
