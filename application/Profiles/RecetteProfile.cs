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
            .ForMember(dest => dest.NameRecette,
            opt => opt.MapFrom(src => src.Name))
             .ForMember(dest => dest.DescriptionRecette,
            opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Id,
            opt => opt.Ignore());
        CreateMap<Recette, RecetteDto>()
            .ForMember(dest => dest.Name,
            opt => opt.MapFrom(src => src.NameRecette))
            .ForMember(dest => dest.Description,
            opt => opt.MapFrom(src => src.DescriptionRecette));
    }
}
