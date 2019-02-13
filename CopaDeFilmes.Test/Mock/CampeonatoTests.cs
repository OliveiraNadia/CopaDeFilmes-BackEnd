using CopaDeFilmes.Domain.Interfaces.Repository;
using CopaDeFilmes.Domain.Models;
using CopaDeFilmes.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaDeFilmes.Test.Mock
{
    public class CampeonatoTests
    {
        private readonly Mock<IFilmeRepository> _filmeRepository;

        public CampeonatoTests()
        {
            _filmeRepository = new Mock<IFilmeRepository>();

            _filmeRepository.Setup(repo => repo.ListarAsync()).Returns(() =>
            {
                return FilmesMock.ListarFilmesAsync();
            });
        }
        [Fact(DisplayName = "Devo Identificar o Campeão e Vice Campeão")]
        public void DevoIdentificarOCampeaoEVice()
        {
            //Arrange
            var servico = new CampeonatoService(_filmeRepository.Object);

            var filmesSelecionados = _filmeRepository.Object.ListarAsync().Result;

            var filmesSelecionadosIds = filmesSelecionados.Take(8).Select(x => x.Id).ToArray();

            //Act
            Campeonato campeonato = servico.GerarCampeonato(filmesSelecionadosIds).Result;

            //Assert
            Assert.Equal("tt4154756", campeonato.Campeao.Id);
            Assert.Equal("tt3606756", campeonato.ViceCampeao.Id);
        }

        [Fact(DisplayName = "Devo Retornar Erro ao Passar Filmes Nulos")]
        public void DevoRetornarErroAoPassarFilmesNulos()
        {
            //Arrange
            var servico = new CampeonatoService(_filmeRepository.Object);

            //Act
            Exception ex = Assert.ThrowsAsync<ArgumentNullException>(async () => await servico.GerarCampeonato(null)).Result;

            //Assert
            Assert.NotNull(ex);
            Assert.IsType<ArgumentNullException>(ex);
        }
    }
}
