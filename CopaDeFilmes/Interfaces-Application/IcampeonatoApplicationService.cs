using CopaDeFilmes.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaDeFilmes.Interfaces_Domain
{
    public interface ICampeonatoApplicationService
    {
        Task<IEnumerable<FilmeViewModel>> GetFilmes();

        IEnumerable<FilmeViewModel> GerarCampeonato(IEnumerable<FilmeViewModel> filmesViewModel);
    }
}
