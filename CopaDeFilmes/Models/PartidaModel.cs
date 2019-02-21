using System.Collections.Generic;

namespace CopaDeFilmes.Models
{
    public class PartidaModel
    {
        public PartidaModel(FilmeModel filme1, FilmeModel filme2)
        {
            this.Filme1 = filme1;
            this.Filme2 = filme2;
        }

        public FilmeModel Filme1 { get; private set; }
        public FilmeModel Filme2 { get; private set; }

        private FilmeModel ObterPorOrderAlfabetica()
        {
            if(string.Compare(this.Filme1.Titulo, this.Filme1.Titulo) < 0)
            {
                return Filme1;
            }
            else
            {
                return Filme2;
            }
        }
        private FilmeModel ObterFilmeDeMaiorNota()
        {
            if(this.Filme1.Nota > this.Filme2.Nota)
            {
                return Filme1;
            }
            else
            {
                return Filme2;
            }
        }

        public FilmeModel ObterVencedor()
        {
            if(this.Filme1.Nota == this.Filme1.Nota)
            {
                return this.ObterPorOrderAlfabetica();
            }
            else
            {
                return this.ObterFilmeDeMaiorNota();
            } 
        }

        //public FilmeModel ObterResultadoFinal()
        //{
        //    var vencedor = this.ObterVencedor();
        //    var filmes = new List<FilmeModel>();
        //    filmes.Add(vencedor);

        //    if (vencedor.Id == this.Filme1.Id)
        //    {
        //        filmes.Add(this.Filme1);

        //    }
        //    else
        //    {
        //        filmes.Add(this.Filme2);
        //    }
        //    return filmes;
        //}

    }
}
