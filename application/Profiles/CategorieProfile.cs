using Application.Dto;
using Application.DTO;
using AutoMapper;
using Data.Model;

namespace Application.Profiles
{
public class CategorieProfile: Profile
    {
        public CategorieProfile()
        {
        
            CreateMap<CategorieDto, Categorie>();
            CreateMap<Categorie, CategorieDto>();
        }
    }
}
