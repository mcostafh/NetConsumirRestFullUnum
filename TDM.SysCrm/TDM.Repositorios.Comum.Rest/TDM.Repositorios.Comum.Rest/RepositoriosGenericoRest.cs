using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using TDM.SysCRM.Dominio;

namespace TDM.Repositorios.Comum.Rest
{
    public class RepositoriosGenericoRest<TEntidade, TChave> : IRepositorioGenericoRest<TEntidade, TChave, TURL>
         where TEntidade : Entidade
    {

       
        public HttpClient _httpClient = new HttpClient();
       
    

        public void Alterar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public void ExcluirPorId(TChave id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(TEntidade entidade)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntidade> Query(Func<TEntidade, bool> func)
        {
            throw new NotImplementedException();
        }

        public List<TEntidade> Selecionar( String url, String param)
        {
            var response = _httpClient.Get("http://troller/api/prdutp?param");

        }

        public TEntidade SelecionarPorId(TChave id)
        {
            throw new NotImplementedException();
        }
    }
}
