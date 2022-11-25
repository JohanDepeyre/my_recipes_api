using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interfaces
{
    public interface IEtapeRepository
    {
        IEnumerable<Etape> GetEtape(int recetteId);

        Etape GetEtapeById(int etapeId);

        Etape CreateEtape(Etape etape);
    }
}
