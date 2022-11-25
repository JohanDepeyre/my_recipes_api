using Application.Dto;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Managers.Interfaces
{
    public interface IEtapeManager
    {
        IEnumerable<EtapeDto> GetEtape(int recetteId);

        EtapeDto GetEtapeById(int etapeId);

        EtapeDto CreateEtape(EtapeDto etape);
    }
}
