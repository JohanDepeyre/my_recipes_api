using Application.DTO;
using AutoMapper;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RecetteProfile : Profile
{
    public RecetteProfile()
    {
        CreateMap<RecetteDto, Recette>()
            .ForMember(dest => dest.TitreRecette,
            opt => opt.MapFrom(src => src.TitreRecette))
             .ForMember(dest => dest.DescriptionRecette,
            opt => opt.MapFrom(src => src.DescriptionRecette))
              .ForMember(dest => dest.DateTimeRecette,
            opt => opt.MapFrom(src => src.DateRecette))
          
            .ForMember(dest => dest.CategorieId,
            opt => opt.MapFrom(src => src.CategorieId))

            .ForMember(dest => dest.RecetteId,
            opt => opt.Ignore());
        CreateMap<Recette, RecetteDto>()
            .ForMember(dest => dest.TitreRecette,
            opt => opt.MapFrom(src => src.TitreRecette))
            .ForMember(dest => dest.DescriptionRecette,
            opt => opt.MapFrom(src => src.DescriptionRecette))
            .ForMember(dest => dest.DateRecette,
          
           
            opt => opt.MapFrom(src => src.CategorieId));

    }
}
