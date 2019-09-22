using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.SysCRM.Dominio
{
    public class Parcelas
    {
        [JsonProperty("chcriacao")]
        public string chavePedido { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("vencimento")]
        public string Vencimento { get; set; }

        [JsonProperty("valor")]
        public string Valor { get; set; }

    }
}
