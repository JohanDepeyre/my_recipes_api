using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto
{
    public class EtapeDto
    {
        public EtapeDto() { }

        public int EtapeId { get; set; }
        public string Titre { get; set; }
        public int TempsEtape { get; set; }
        public string Description { get; set; }
        public int IdRecette { get; set; }
        public Recette recette { get; set; }
    }
}
