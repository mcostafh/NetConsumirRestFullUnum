using System.Collections.Generic;

namespace TDM.SysCRM.ViewModels
{
    public interface IFiltroViewModel<TExibicaoViewModel> : IViewModel
        where TExibicaoViewModel: IExibicaoViewModel
    {
        IEnumerable<TExibicaoViewModel> Exibicao { get; set; }
    }
}