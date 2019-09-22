using Newtonsoft.Json;

namespace TDM.SysCRM.Dominio
{

    public class Veiculo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("codigo")]
        public string Codigo { get; set; }

        [JsonProperty("anomodelo")]
        public string Anomodelo { get; set; }

        [JsonProperty("anofabric")]
        public string Anofabric { get; set; }

        [JsonProperty("renavanveiculo")]
        public string Renavanveiculo { get; set; }

        [JsonProperty("basechassi")]
        public string Basechassi { get; set; }

        [JsonProperty("token")]
        public string token { get; set; }

    }
}
