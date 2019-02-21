using CopaDeFilmes.Exceptions;
using CopaDeFilmes.Models;
using System;
using System.Collections.Generic;

namespace CopaDeFilmes.Validation
{
    public static class FilmesValidation
    {
        public static void ValidaNulo(object item)
        {
            if(item == null)
            {
                throw new ArgumentException();
            }
        }

        public static void ValidaFilme(FilmeModel filme)
        {
            if(filme == null)
            {
                throw new FilmeInvalidoExceptions();
            }
        }

        public static void Valida8Filme(List<FilmeModel> filmes)
        {
            if(filmes == null || filmes.Count != 8)
            {
                throw new ListaDeFilmesInvalidaExceptions();
            }
        }

    }
}
