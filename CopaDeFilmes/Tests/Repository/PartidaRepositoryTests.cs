using CopaDeFilmes.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CopaDeFilmes.Tests.Repository
{
    public class PartidaRepositoryTests : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {new PartidaModel(new FilmeModel() {Nota=8, Id="GANHADOR", Titulo="América" }, new FilmeModel() { Nota = 7, Id = "2", Titulo="Brasil" }) },
            new object[] {new PartidaModel(new FilmeModel() {Nota=7, Id="2", Titulo="América" }, new FilmeModel() { Nota = 8, Id = "GANHADOR", Titulo="Brasil" }) },
            new object[] {new PartidaModel(new FilmeModel() {Nota=8, Id= "GANHADOR", Titulo="América" }, new FilmeModel() { Nota = 8, Id = "2", Titulo="Brasil" }) },
            new object[] {new PartidaModel(new FilmeModel() {Nota=8, Id= "2", Titulo = "Brasil" }, new FilmeModel() { Nota = 8, Id = "GANHADOR", Titulo = "América" }) },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
