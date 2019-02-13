using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Application.Exceptions
{
    public class ListaDeFilmesInvalidaException : Exception
    {
        public ListaDeFilmesInvalidaException(string msgErro) : base(msgErro)
        {

        }

        public ListaDeFilmesInvalidaException() : base("Número de filmes é inválido.")
        {

        }
    }
}
