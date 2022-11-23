using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interfaces
{
    public interface IRecetteRepository
    {
        IEnumerable<Recette> GetRecette();

        Recette GetRecetteById(int recetteId);

        Recette CreateRecette(Recette recette);
    }
}
