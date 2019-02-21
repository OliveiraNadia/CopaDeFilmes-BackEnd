using CopaDeFilmes.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaDeFilmes.Interfaces.Repository
{
    public interface IFilmeRepository
    {
        Task<List<FilmeModel>> ListaFilmes();
    }
}
