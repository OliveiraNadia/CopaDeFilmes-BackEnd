using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaDeFilmes.Extensions;

namespace CopaDeFilmes.Models
{
    public class CampeonatoModel
    {
        //public CampeonatoModel(List<FilmeModel> filmes)
        //{
        //    filmes = this.OrdenarFilmes(filmes);
        //    this.GerarPartidas(filmes);

        //}
        public FilmeModel Campeao { get;  private set; }

        public FilmeModel ViceCampeao { get; private set; }

        private List<FilmeModel> OrdenarFilmes(List<FilmeModel> filmes)
        {
            return filmes.OrderBy(o => o.Titulo).ToList();
        }

        //private void GerarPartidas(List<FilmeModel> filmes)
        //{
        //    List<PartidaModel> partidas = new List<PartidaModel>();

        //    while (filmes.Count > 0)
        //    {
        //        partidas.Add(new PartidaModel(filmes.First(), filmes.Last()));
        //        filmes.Remove(filmes.First());
        //        filmes.Remove(filmes.Last());
        //    }

        //    if (partidas.Count == 1)
        //    {
        //        this.ExecutarUltimaPartida(partidas.First());
        //        return;

        //    }
        //    List<FilmeModel> vencedores = partidas.ObterVencedores();

        //    this.GerarPartidas(vencedores);
        //}
        //private void ExecutarUltimaPartida(PartidaModel final)
        //{
        //    var vencedores = final.ObterResultadoFinal();
        //    this.Campeao = vencedores[0];
        //    this.ViceCampeao = vencedores[1];
        //}
    }
}
