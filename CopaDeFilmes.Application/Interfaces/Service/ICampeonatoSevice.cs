using System;
using System.Threading.Tasks;
using CopaDeFilmes.Domain.Models;

namespace CopaDeFilmes.Domain
{
    public interface ICampeonatoService
    {
        ValueTask<Campeonato> GerarCampeonato(string[] IdFilmes);
    }
}
