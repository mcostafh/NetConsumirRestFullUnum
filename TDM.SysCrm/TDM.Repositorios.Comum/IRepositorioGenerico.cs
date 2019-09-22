using System;
using System.Collections.Generic;
using System.Linq;

namespace TDM.Repositorios.Comum
{
    public interface IRepositorioGenerico<TEntidade, TChave>
      where TEntidade : class
    {
        List<TEntidade> Selecionar(String Uri, String param);

        IQueryable<TEntidade> Query(Func<TEntidade, bool> func);
        TEntidade SelecionarPorId(TChave id);
        
        void Inserir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        void Excluir(TEntidade entidade);
        void ExcluirPorId(TChave id);
    }
}
