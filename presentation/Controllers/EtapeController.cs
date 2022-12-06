using Application.Dto;
using Application.DTO;
using Application.Managers;
using Application.Managers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtapeController : Controller
    {
        private IEtapeManager EtapeManager { get; }
        public EtapeController(IEtapeManager etapeManager)
        {
            this.EtapeManager = etapeManager;
        }
        [HttpGet("{recetteId:int}")]
        public IEnumerable<EtapeDto> GetEtapeByRecette(int recetteId)
        {
            return EtapeManager.GetEtape(recetteId);

        }

        //[HttpGet("{etapeId:int}")]
        //public EtapeDto GetEtapeById([FromQuery] int etapeId)
        //{
        //    return EtapeManager.GetEtapeById(etapeId);

        //}

        [HttpPost]
        public EtapeDto CreateEtape([FromBody] EtapeDto etape)
        {
            return EtapeManager.CreateEtape(etape);

        }
    }
}
