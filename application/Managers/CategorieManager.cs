using Application.Dto;
using Application.Managers.Interfaces;
using AutoMapper;
using Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Managers
{
    public class CategorieManager:ICategorieManager
    {
        private ICategorieRepository CategorieRepository { get; }
        private IMapper Mapper { get; }
        public CategorieManager(ICategorieRepository categorieRepository, IMapper mapper)
        {
            this.CategorieRepository = categorieRepository;
            this.Mapper = mapper;
        }

        public IEnumerable<CategorieDto> GetCategories()
        {
            var response = CategorieRepository.GetCategorie();
           return Mapper.Map< IEnumerable<CategorieDto>>(response);
        }
    }
}
