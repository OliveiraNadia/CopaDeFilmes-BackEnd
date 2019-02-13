using CopaDeFilmes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CopaDeFilmes.Application.Extensions
{
    public static class PartidaExtensions
    {
        public static List<Filme> ObterVencedores(this List<Partida> partidas)
        {
            return partidas.Select(x => x.ObterVencedor()).ToList();
        }
    }
}
