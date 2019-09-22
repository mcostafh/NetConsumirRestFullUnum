using System.ComponentModel.DataAnnotations;

namespace TDM.SysCRM.ViewModels.StatusAcionamento
{
    public class StatusAcionamentoViewModel : IViewModel
    {
        [Required(ErrorMessage = "O ID é obrigatório")]
        public long Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [MaxLength(100, ErrorMessage = "O Nome do Motivo de acionamento deve ter no máximo 100 Caracteres")]
        public string Nome { get; set; }
    }
}