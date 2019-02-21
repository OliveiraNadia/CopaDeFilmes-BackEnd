using AutoMapper;
using CopaDeFilmes.Models;
using CopaDeFilmes.ViewModel;

namespace CopaDeFilmes.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<FilmeViewModel, FilmeModel>()
                  .ForMember(dest => dest.Titulo, options => options.MapFrom(src => src.Titulo))
                  .ForMember(dest => dest.Ano, options => options.MapFrom(src => src.Ano));

        }
    }
}
