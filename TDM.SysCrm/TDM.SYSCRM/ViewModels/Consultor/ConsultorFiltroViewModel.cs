using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TDM.SysCRM.ViewModels.Consultor
{
    public class ConsultorFiltroViewModel : IFiltroViewModel<ConsultorExibicaoViewModel>
    {
        [Display(Name = "Nome do Consultor")]
        public string Nome { get; set; }

        public IEnumerable<ConsultorExibicaoViewModel> Exibicao { get; set; }
    }
}