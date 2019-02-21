using CopaDeFilmes.ViewModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaDeFilmes.Models;

namespace CopaDeFilmes.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<FilmeModel, FilmeViewModel>()
                .ForMember(dest => dest.Titulo, options => options.MapFrom(src => src.Titulo))
                .ForMember(dest => dest.Ano, options => options.MapFrom(src => src.Ano))
                .ForMember(dest => dest.Campeao, options => options.MapFrom(src => src.Campeao));
        }
    }
}
