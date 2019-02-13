using CopaDeFilmes.Controllers;
using CopaDeFilmes.Domain.Interfaces.Repository;
using CopaDeFilmes.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Test.Mock.Api
{
    public class CampeonatoControllerTests
    {
        private readonly Mock<IFilmeRepository> _filmeRepository;

        public CampeonatoControllerTests()
        {
            _filmeRepository = new Mock<IFilmeRepository>();

            _filmeRepository.Setup(repo => repo.ListaFilmes()).Returns(() =>
            {
                return FilmesMock.ListarFilmesAsync();
            });
        }

        [Fact(DisplayName = "Devo Identificar o Campeão e Vice Campeão pela controller de campeonato")]
        public void DevoIdentificarOCampeaoEVice()
        {
            //Arrange
            var controller = new CampeonatoController(new CampeonatoService(_filmeRepository.Object));

            var filmesSelecionados = _filmeRepository.Object.ListaFilmes().Result;

            var filmesSelecionadosIds = filmesSelecionados.Take(8).Select(x => x.Id).ToArray();

            //Act
            var campeonato = ((OkObjectResult)controller.GerarCampeonato(filmesSelecionadosIds).Result).Value as Campeonato;

            //Assert
            Assert.Equal("tt4154756", campeonato.Campeao.Id);
            Assert.Equal("tt3606756", campeonato.ViceCampeao.Id);
        }
    }
}
