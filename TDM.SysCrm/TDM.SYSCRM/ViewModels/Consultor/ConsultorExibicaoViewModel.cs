using System.ComponentModel.DataAnnotations;

namespace TDM.SysCRM.ViewModels.Consultor
{
    public class ConsultorExibicaoViewModel : IExibicaoViewModel
    {
        public long Id { get; set; }

        [Display(Name = "Nome do Consultor")]
        public string Nome { get; set; }

        [Display(Name = "Recebe Leads")]
        public bool RecebeDistribuicaoLeads { get; set; }

    }
}