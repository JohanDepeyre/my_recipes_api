using Application.DTO;
using Application.Managers.Interfaces;
using AutoMapper;
using Data.Model;
using Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Managers
{
    public class RecetteManager : IRecetteManager
    {
        private IRecetteRepository RecetteRepository { get; }
        private IMapper Mapper { get; }
        public RecetteManager(IRecetteRepository recetteRepository, IMapper mapper)
        {
            this.RecetteRepository = recetteRepository;
            this.Mapper = mapper;
        }

        public IEnumerable<RecetteDto> GetRecette()
        {
            var response = this.RecetteRepository.GetRecette();

            return Mapper.Map<IEnumerable<RecetteDto>>(response);
        }

        public RecetteDto GetRecetteById(int recetteId)
        {
            var response = this.RecetteRepository.GetRecetteById(recetteId);
            return Mapper.Map<RecetteDto>(response);
        }
        public RecetteDto CreateRecette(RecetteDto recette)
        {
            var entity = Mapper.Map<Recette>(recette);
            var response = this.RecetteRepository.CreateRecette(entity);

            return Mapper.Map<RecetteDto>(response);
        }
    }
}
