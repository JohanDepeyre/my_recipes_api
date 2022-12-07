using Application.Dto;
using Application.Managers;
using Application.Managers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategorieController : Controller
    {
        private ICategorieManager CategorieManager { get; }
        public CategorieController(ICategorieManager categorieManager)
        {
            this.CategorieManager = categorieManager;


        }
        [HttpGet()]
        public IEnumerable<CategorieDto> GetCategories()
        {
            return CategorieManager.GetCategories();

        }
    }
}
