﻿using Application.DTO;
using Application.Managers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecetteController : Controller
    {
        private IRecetteManager RecetteManager { get; }
        public RecetteController(IRecetteManager recettemanager)
        {
            this.RecetteManager = recettemanager;
        }

        [HttpGet]
        public IEnumerable<RecetteDto> GetRecette()
        {
            return RecetteManager.GetRecette();
        }
        [HttpGet("{recetteId:int}")]
        public RecetteDto GetRecetteById(int recetteId)
        {
            return RecetteManager.GetRecetteById(recetteId);
        }
        [HttpPost]
        public RecetteDto PostRecette([FromBody] RecetteDto category)
        {
            return RecetteManager.CreateRecette(category);
        }
    }
}