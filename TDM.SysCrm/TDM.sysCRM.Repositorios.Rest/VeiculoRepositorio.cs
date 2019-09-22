using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using TDM.SysCRM.Dominio;

namespace TDM.sysCRM.Repositorios.Rest
{
    public class VeiculoRepositorio
    {
    

        public List<Veiculo> Listar()
        {

            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "01WTtqQNeyyWOShfln8ihyCfcY3ha69OjV197afjHMwrK3_hXCsY7bSLt_ISYUgQgR");

            var response = httpClient.GetAsync("http://127.0.0.1:80/api/api-troller/v1/veiculos").GetAwaiter().GetResult();
            //var responsePost = httpClient.Post("http://troller/api/prdutp?param", new { body = "strin" });
            var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var obj = JsonConvert.DeserializeObject<List<Veiculo>>(json);


            return obj;
        }
        public Veiculo Buscar(int? id)
        {

            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "01WTtqQNeyyWOShfln8ihyCfcY3ha69OjV197afjHMwrK3_hXCsY7bSLt_ISYUgQgR");

            var response = httpClient.GetAsync("http://127.0.0.1:80/api/api-troller/v1/veiculos/" + id).GetAwaiter().GetResult();
            //var responsePost = httpClient.Post("http://troller/api/prdutp?param", new { body = "strin" });
            var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var obj = JsonConvert.DeserializeObject<Veiculo>(json);


            return obj;
        }
        public Veiculo Salvar(Veiculo veic)
        {

            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "01WTtqQNeyyWOShfln8ihyCfcY3ha69OjV197afjHMwrK3_hXCsY7bSLt_ISYUgQgR");


            veic.token = "01XG3yBbMxvX8aPrVNgnMVzrr*UqeJRrHL4bUwKl0gu*AZLP2yv12n5IaZ7907Y40P";
            var xjson = JsonConvert.SerializeObject(veic);

            var bodyContent = new StringContent(xjson);

                     

            var response = httpClient.PutAsync("http://127.0.0.1:80/api/api-troller/v1/veiculos/" + veic.Id, bodyContent).GetAwaiter().GetResult();
            
           
             var json = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            if (!response.IsSuccessStatusCode)
            {
                var xc = JsonConvert.DeserializeObject<RequestErrorViewModel>(json);
                throw new Exception("Erro: " + xc.message);
            }
           var obj = JsonConvert.DeserializeObject<Veiculo>(json);

            return obj;
        }

    }

    internal class RequestErrorViewModel
    {
        public string message { get; set; }
    }
}
