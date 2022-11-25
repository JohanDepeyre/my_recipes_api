using Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Managers.Interfaces
{
    public interface ICategorieManager
    {
        IEnumerable<CategorieDto> GetCategories();
    }
}
