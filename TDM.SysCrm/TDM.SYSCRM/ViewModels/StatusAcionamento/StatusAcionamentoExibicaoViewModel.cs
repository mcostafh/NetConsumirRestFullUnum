using System.ComponentModel.DataAnnotations;

namespace TDM.SysCRM.ViewModels.StatusAcionamento
{
    public class StatusAcionamentoExibicaoViewModel : IExibicaoViewModel
    {
        public long Id { get; set; }

        [Display(Name = "Nome ")]
        public string Nome { get; set; }

    }
}