using AutoMapper;
using CopaDeFilmes.Interfaces.Service;
using CopaDeFilmes.Interfaces_Domain;
using CopaDeFilmes.Models;
using CopaDeFilmes.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDeFilmes.Services
{
    public class CampeonatoFilmesService : ICampeonatoApplicationService
    {
        private readonly ICampeonatoService _campeonatoService;
        private readonly IMapper _mapper;

        public CampeonatoFilmesService(ICampeonatoService campeonatoService, IMapper mapper)
        {
            _campeonatoService = campeonatoService;
            _mapper = mapper;
        }

        public IEnumerable<FilmeViewModel> GerarCampeonato(IEnumerable<FilmeViewModel> filmesViewModel)
        {
            var listFilmes = Mapper.Map<IEnumerable<FilmeModel>>(filmesViewModel);

            var chaveamentoFilmes = _campeonatoService.CriarChaveamento(listFilmes.ToList());

            var partida = _campeonatoService.Partida(chaveamentoFilmes);

            var resultadoFinal = _campeonatoService.ResultadoFinal(partida);

            var vencedores = Mapper.Map<IEnumerable<FilmeViewModel>>(resultadoFinal);

            return vencedores;
        }

        public async Task<IEnumerable<FilmeViewModel>> GetFilmes()
        {
            var filmes = await _campeonatoService.GetFilmes();
            var lstFilmes = Mapper.Map<IEnumerable<FilmeViewModel>>(filmes);

            return lstFilmes;
        }

    }
}
