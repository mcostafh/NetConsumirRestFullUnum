using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.SysCRM.Dominio
{
    public class ItensPedido
    {

       [JsonProperty("codRecurso")]
        public string CodRecurso { get; set; }

        [JsonProperty("nomeRecurso")]
        public string NomeRecurso { get; set; }

        [JsonProperty("quantidade")]
        public string Quantidade { get; set; }

        [JsonProperty("unitario")]
        public string Unitario { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("totalProduto")]
        public string TotalDoProduto { get; set; }


    }
}
