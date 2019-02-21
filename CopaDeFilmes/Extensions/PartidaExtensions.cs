using CopaDeFilmes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDeFilmes.Extensions
{
    public static class PartidaExtensions 
    {
        public static List<FilmeModel> ObterVencedores(this List<PartidaModel> partidas)
        {
            return partidas.Select(s => s.ObterVencedor()).ToList();
        }
    }
}
