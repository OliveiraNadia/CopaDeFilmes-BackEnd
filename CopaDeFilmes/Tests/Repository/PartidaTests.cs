using CopaDeFilmes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDeFilmes.Tests.Repository
{
    public class PartidaTests
    {
        [Theory(DisplayName = "Devo identificar o vencedor da partida")]
        [ClassData(typeof(PartidaRepositoryTests))]
        public void DevoIdentificarOVencedorDasPartidas(PartidaModel partida)
        {
            //Act
            var vencedor = partida.ObterVencedor();

            //Assert
            Assert.Equal("GANHADOR", vencedor.Id);
        }
    }
}
