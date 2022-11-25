
using Application.Dto;
using Application.DTO;
using AutoMapper;
using Data.Model;

namespace Application.Profiles
{
    public class EtapeProfile : Profile
    {
        public EtapeProfile()
        {
            CreateMap<EtapeDto, Etape>();
            CreateMap<Etape, EtapeDto>();
        }
    }
}
