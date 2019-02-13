using System;
using System.Threading.Tasks;
using CopaDeFilmes.Domain.Models;

namespace CopaDeFilmes.Domain.Interfaces.Services
{
    public interface ICampeonatoService
    {
        ValueTask<Campeonato> GerarCampeonato(string[] IdFilmes);
    }
}
