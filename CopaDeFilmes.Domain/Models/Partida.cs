using System;
using System.Collections.Generic;
using System.Text;
using CopaDeFilmes.Application.Validation;

namespace CopaDeFilmes.Domain.Models
{
    public class Partida
    {
        public Partida(Filme filme1, Filme filme2)
        {
            FilmesValidation.ValidaFilmeValido(filme1);
            FilmesValidation.ValidaFilmeValido(filme2);

            this.Filme1 = filme1;
            this.Filme2 = filme2;

        }
        public Filme Filme1 { get; private set; }

        public Filme Filme2 { get; private set; }
        
        public Filme ObterVencedor()
        {
            if(this.Filme1.Nota == this.Filme1.Nota)
            {
                return this.ObterVencedorPorOrdemAlfabetica();
            }
            else
            {
                return this.ObterVencedorPorNota();
            }
        }
        public List<Filme> ObterResultadoFinal()
        {
            var vencedor = this.ObterVencedor();
            List<Filme> filmes = new List<Filme>();
            filmes.Add(vencedor);

            if(vencedor.Id == this.Filme1.Id)
            {
                filmes.Add(this.Filme2);
            }
            else
            {
                filmes.Add(Filme1);
            }

            return filmes;

        }
        private Filme ObterVencedorPorNota()
        {
            if (this.Filme1.Nota > this.Filme2.Nota)
            {
                return this.Filme1;
            }
            else
            {
                return this.Filme2;
            }
        }

        private Filme ObterVencedorPorOrdemAlfabetica()
        {
            if (string.Compare(this.Filme1.Titulo, this.Filme2.Titulo) < 0)
            {
                return Filme1;
            }
            else
            {
                return Filme2;
            }
        }

    }
}
