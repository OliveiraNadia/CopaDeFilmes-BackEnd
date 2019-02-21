using CopaDeFilmes.Interfaces.Repository;
using CopaDeFilmes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDeFilmes.Tests.Api
{
    public class FilmeControllerTests
    {
        private readonly Mock<IFilmeRepository> _filmeRepository;

        public FilmeControllerTests()
        {
            _filmeRepository = new Mock<IFilmeRepository>();

            _filmeRepository.Setup(repo => repo.ListarAsync()).Returns(() =>
            {
                return FilmesMock.ListarFilmesAsync();
            });
        }

        [Fact(DisplayName = "Devo listar filmes a partir da controller de filmes")]
        public void DevoIdentificarOCampeaoEVice()
        {
            //Arrange
            var controller = new FilmeController(_filmeRepository.Object);

            //Act
            var filmes = ((OkObjectResult)controller.Obter().Result).Value as List<FilmeModel>;

            //Assert

            Assert.NotNull(filmes);

            Assert.Equal(16, filmes.Count);
        }
    }
}
