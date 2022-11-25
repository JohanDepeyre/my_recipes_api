using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Managers.Interfaces
{
    public interface IRecetteManager
    {
        RecetteDto CreateRecette(RecetteDto category);
        IEnumerable<RecetteDto> GetRecette();
        RecetteDto GetRecetteById(int categoryId);

    }
}
