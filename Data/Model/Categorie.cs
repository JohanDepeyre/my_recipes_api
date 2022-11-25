using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Categorie
    {
        public int CategorieId { get; set; }
        public string Titre { get; set; }
        public List<Recette> Recettes { get; set; }
    }
}
