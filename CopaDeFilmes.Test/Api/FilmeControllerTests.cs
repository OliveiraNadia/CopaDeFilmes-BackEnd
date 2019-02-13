using CopaDeFilmes.Domain.Interfaces.Repository;
using CopaDeFilmes.Domain.Models;
using CopaDeFilmes.Test.Mock;
using CopaDeFilmes.Api.Controller;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Test.Mock.Api
{
    public class FilmeControllerTests
    {
        private readonly Mock<IFilmeRepositorio> _filmeRepositorio;

        public FilmeControllerTests()
        {
            _filmeRepositorio = new Mock<IFilmeRepositorio>();

            _filmeRepositorio.Setup(repo => repo.ListarAsync()).Returns(() =>
            {
                return FilmesMock.ListarFilmesAsync();
            });
        }

        [Fact(DisplayName = "Devo listar filmes a partir da controller de filmes")]
        public void DevoIdentificarOCampeaoEVice()
        {
            //Arrange
            var controller = new FilmeController(_filmeRepositorio.Object);

            //Act
            var filmes = ((OkObjectResult)controller.Obter().Result).Value as List<Filme>;

            //Assert

            Assert.NotNull(filmes);

            Assert.Equal(16, filmes.Count);
        }
    }
}
