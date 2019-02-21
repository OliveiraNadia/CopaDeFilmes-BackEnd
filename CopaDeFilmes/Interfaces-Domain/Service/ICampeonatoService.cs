using CopaDeFilmes.Models;
using CopaDeFilmes.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaDeFilmes.Interfaces.Service
{
    public interface ICampeonatoService
    {
        //Task<CampeonatoModel> GetCampeonato(string[] IdFilmes);
        Task<IEnumerable<FilmeModel>> GetFilmes();

        List<Tuple<FilmeModel, FilmeModel>> CriarChaveamento(List<FilmeModel> filmes);
        //(Tuple<Filme, Filme>, Tuple<Filme, Filme>, Tuple<Filme, Filme>, Tuple<Filme, Filme>) CriarChaveamento(List<Filme> filmes);

        Tuple<FilmeModel, FilmeModel> Partida(List<Tuple<FilmeModel, FilmeModel>> filmes);

        Tuple<FilmeModel, FilmeModel> ResultadoFinal(Tuple<FilmeModel, FilmeModel> filmes);
    }
}
