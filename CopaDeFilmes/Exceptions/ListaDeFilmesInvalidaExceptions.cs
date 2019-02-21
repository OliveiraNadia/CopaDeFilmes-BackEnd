using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDeFilmes.Exceptions
{
    public class ListaDeFilmesInvalidaExceptions : Exception
    {
        public ListaDeFilmesInvalidaExceptions(string msgErro) : base(msgErro) { }

        public ListaDeFilmesInvalidaExceptions() : base("Numero de Filmes Inválida.") { }
    }
}
