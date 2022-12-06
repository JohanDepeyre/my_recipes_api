using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Recette
    {
   
        public int RecetteId { get; set; }
        public string TitreRecette { get; set; } 
        public string? DescriptionRecette { get; set; }
        public DateTime DateTimeRecette { get; set; }

        public int CategorieId { get; set; }
  
    }
}
