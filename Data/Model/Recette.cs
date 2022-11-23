using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Recette
    {
        public Recette()
        {
        }
        public int Id { get; set; }
        public string NameRecette { get; set; } = null!;
        public string? DescriptionRecette { get; set; }
    }
}
