using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShoesWebsite.Models
{
    public class ShoePage
    {
        public int ID { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }


        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]

        public decimal Pret { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Marime { get; set; }

        public string Brand { get; set; }

        public string Categorie { get; set; }



    }
}
