using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CopaDeFilmes.Domain.Interfaces.Repository;
using CopaDeFilmes.Domain.Models;
using CopaDeFilmes.Domain.Interfaces.Services;

namespace CopaDeFilmes.Domain.Services
{
    public class CampeonatoService : ICampeonatoService
    {
        private readonly IFilmeRepository _filmeRepository;

        public CampeonatoService(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }
        public async ValueTask<Campeonato> GerarCampeonato(string[] IdFilmes)
        {
            List<Filme> filmes = await _filmeRepository.ListaFilmes();
            filmes = filmes.FindAll(f => IdFilmes.Any(a => a == f.Id));

            return new Campeonato(filmes);
        }
    }

}
