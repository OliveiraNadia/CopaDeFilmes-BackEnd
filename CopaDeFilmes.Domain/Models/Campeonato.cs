using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CopaDeFilmes.Domain.Models
{
    public class Campeonato
    {
        public Campeonato(List<Filme>filmes)
        {
            filmes = this.OrdenarFilmes(filmes);
            this.GerarPartidas(filmes);
            
        }
        public Filme Campeao { get; private set; }

        public Filme ViceCampeao { get; private set; }

        private List<Filme> OrdenarFilmes(List<Filme> filmes)
        {
            return filmes.OrderBy(o => o.Titulo).ToList();
        }

        private void GerarPartidas(List<Filme>filmes)
        {
            List<Partida> partidas = new List<Partida>();

            while(filmes.Count > 0)
            {
                partidas.Add(new Partida(filmes.First(), filmes.Last()));
                filmes.Remove(filmes.First());
                filmes.Remove(filmes.Last());
            }

            if (partidas.Count == 1)
            {
                this.ExecutarUltimaPartida(partidas.First());
                return;

            }
            List<Filme> vencedores = partidas.ObterVencedor();

            this.GerarPartidas(vencedores);
        }
        private void ExecutarUltimaPartida(Partida final)
        {
            var vencedores = final.ObterResultadoFinal();
            this.Campeao = vencedores[0];
            this.ViceCampeao = vencedores[1];
        }
    }
}
