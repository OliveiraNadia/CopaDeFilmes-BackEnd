using CopaDeFilmes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CopaDeFilmes.Domain.Interfaces.Repository
{
    public interface IFilmeRepository
    {
        ValueTask<List<Filme>> ListaFilmes();
    }
}
