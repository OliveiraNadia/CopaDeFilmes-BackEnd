using CopaDeFilmes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Test.Repository
{
    public class PartidaRepositoryTests : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {new Partida(new Filme() {Nota=8, Id="GANHADOR", Titulo="América" }, new Filme() { Nota = 7, Id = "2", Titulo="Brasil" }) },
            new object[] {new Partida(new Filme() {Nota=7, Id="2", Titulo="América" }, new Filme() { Nota = 8, Id = "GANHADOR", Titulo="Brasil" }) },
            new object[] {new Partida(new Filme() {Nota=8, Id= "GANHADOR", Titulo="América" }, new Filme() { Nota = 8, Id = "2", Titulo="Brasil" }) },
            new object[] {new Partida(new Filme() {Nota=8, Id= "2", Titulo = "Brasil" }, new Filme() { Nota = 8, Id = "GANHADOR", Titulo = "América" }) },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
