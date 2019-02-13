using CopaDeFilmes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Test.Repository
{
    public class PartidaTests
    {
        [Theory(DisplayName = "Devo identificar o vencedor da partida")]
        [ClassData(typeof(PartidaRepositoryTests))]
        public void DevoIdentificarOVencedorDasPartidas(Partida partida)
        {
            //Act
            var vencedor = partida.ObterVencedor();

            //Assert
            Assert.Equal("GANHADOR", vencedor.Id);
        }
    }
}
