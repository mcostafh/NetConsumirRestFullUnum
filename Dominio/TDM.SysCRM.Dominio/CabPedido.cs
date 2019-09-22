using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.SysCRM.Dominio
{
    public class CabPedido
    {
        [JsonProperty("chcriacao")]
        public string Chcriacao { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("emissao")]
        public string Emissao { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("tipo")]
        public string Tipo { get; set; }

        [JsonProperty("aprovacao")]
        public string Aprovacao { get; set; }

        [JsonProperty("aprovador")]
        public string Aprovador { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("itens")]
        public List<ItensPedido> ItensDoPedido;

        [JsonProperty("parcelas")]
        public List<Parcelas> ParcelasDoPedido;
    }
}
