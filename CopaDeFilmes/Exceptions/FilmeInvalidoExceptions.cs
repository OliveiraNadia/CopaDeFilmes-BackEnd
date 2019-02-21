using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDeFilmes.Exceptions
{
    public class FilmeInvalidoExceptions : Exception
    {
        public FilmeInvalidoExceptions(string msgErro) : base(msgErro) { }

        public FilmeInvalidoExceptions() : base("Filme Inválido.") { }
    }
}
