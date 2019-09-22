using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using TDM.SysCRM.Dominio;

namespace TDM.sysCRM.Repositorios.Rest
{
    public class PedidoRepositorio
    {


        public CabPedido Buscar(int? id)
        {

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "01WTtqQNeyyWOShfln8ihyCfcY3ha69OjV197afjHMwrK3_hXCsY7bSLt_ISYUgQgR");

            var response = httpClient.GetAsync("http://127.0.0.1:80/api/api-troller/v1/pedido/" + id).GetAwaiter().GetResult();
            var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var obj = JsonConvert.DeserializeObject<CabPedido>(json);


            return obj;
        }

    }

}
