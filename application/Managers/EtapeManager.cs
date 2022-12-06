using Application.Dto;
using Application.DTO;
using Application.Managers.Interfaces;
using AutoMapper;
using Data.Model;
using Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Application.Managers
{

    public class EtapeManager : IEtapeManager
    {
        private IEtapeRepository EtapeRepository { get; }
        private IMapper Mapper { get; }
        public EtapeManager(IEtapeRepository etapeRepository, IMapper mapper)
        {
            this.EtapeRepository = etapeRepository;
            this.Mapper = mapper;
        }
        public EtapeDto CreateEtape(EtapeDto etape)
        {
            var entity = Mapper.Map<Etape>(etape);
            var response = this.EtapeRepository.CreateEtape(entity);

            return Mapper.Map<EtapeDto>(response);
        }

        public IEnumerable<EtapeDto> GetEtape(int recetteId)
        {
            var response = EtapeRepository.GetEtape(recetteId);
            return Mapper.Map<IEnumerable<EtapeDto>>(response);


        }

        public EtapeDto GetEtapeById(int etapeId)
        {
          var response = EtapeRepository.GetEtapeById(etapeId);

            return Mapper.Map<EtapeDto>(response);
        }
    }
}
