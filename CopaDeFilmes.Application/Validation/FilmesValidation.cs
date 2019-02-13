using CopaDeFilmes.Application.Exceptions;
using CopaDeFilmes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Application.Validation
{
    public static class FilmesValidation
    {
        public static void ValidaNulo(object item)
        {
            if (item == null)
            {
                throw new ArgumentException();
            }
        }
        public static void ValidaFilmeValido(Filme filme)
        {
            if (filme == null)
            {
                throw new FilmeInvalidoException();
            }
        }

        public static void Valida8Filmes(List<Filme> filmes)
        {
            if(filmes == null || filmes.Count != 8)
            {
                throw new ListaDeFilmesInvalidaException();
            }
        }
    }
}
}
