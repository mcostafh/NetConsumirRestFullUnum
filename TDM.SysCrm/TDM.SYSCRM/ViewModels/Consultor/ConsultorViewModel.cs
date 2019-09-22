using System.ComponentModel.DataAnnotations;

namespace TDM.SysCRM.ViewModels.Consultor
{
    public class ConsultorViewModel : IViewModel
    {
        //[Required(ErrorMessage = "O ID é obrigatório")]
        public long Id { get; set; }

        [Display(Name = "Nome do Consultor")]
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [MaxLength(200, ErrorMessage = "O Nome do Consultor deve ter no máximo 100 Caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Recebe Distribuição de Leads")]
        public bool RecebeDistribuicaoLeads { get; set; }


        public ConsultorViewModel()
        {
            Id = 10;
        }
    }
}