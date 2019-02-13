using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Application.Exceptions
{
    public class FilmeInvalidoException : Exception
    {
        public FilmeInvalidoException(string msgErro) : base(msgErro)
        {

        }

        public FilmeInvalidoException() : base("Filme inválido.")
        {

        }
    }

}
