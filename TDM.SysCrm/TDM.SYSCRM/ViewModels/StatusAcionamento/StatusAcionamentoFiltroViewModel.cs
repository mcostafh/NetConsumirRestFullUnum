using System.Collections.Generic;

namespace TDM.SysCRM.ViewModels.StatusAcionamento
{
    public class StatusAcionamentoFiltroViewModel : IMotivoAcionamentoFiltroViewModel
    {
        public string Nome { get; set; }
        public IEnumerable<StatusAcionamentoExibicaoViewModel> Exibicao { get; set; }
    }
}