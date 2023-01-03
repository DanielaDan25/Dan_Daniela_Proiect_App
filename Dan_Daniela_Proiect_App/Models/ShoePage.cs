
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dan_Daniela_Proiect_App.Models
{
    public class ShoePage
    {
        public int ID { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }

        public decimal Pret { get; set; }

        
        public decimal Marime { get; set; }

        public string Brand { get; set; }

        public string Categorie { get; set; }

    }
}
