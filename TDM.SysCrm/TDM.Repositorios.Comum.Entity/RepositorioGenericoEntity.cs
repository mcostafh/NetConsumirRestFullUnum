using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TDM.SysCRM.Dominio;

namespace TDM.Repositorios.Comum.Entity
{
    public class RepositorioGenericoEntity<TEntidade, TChave> : IRepositorioGenerico<TEntidade, TChave>
         where TEntidade : Entidade
    {
        protected DbContext _contexto;

        public RepositorioGenericoEntity(DbContext contexto) 
            => _contexto = contexto;

        public void Alterar(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Excluir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Deleted;
            _contexto.SaveChanges();
        }

        public void ExcluirPorId(TChave id)
        {
            TEntidade entidade = SelecionarPorId(id);
            Excluir(entidade);
        }

        public void Inserir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Add(entidade);
            _contexto.SaveChanges();
        }

        public virtual List<TEntidade> Selecionar() 
            => _contexto.Set<TEntidade>().ToList();

        public IQueryable<TEntidade> Query(Func<TEntidade, bool> func) 
            => _contexto.Set<TEntidade>().Where(func).AsQueryable();

        public virtual TEntidade SelecionarPorId(TChave id) 
            => _contexto.Set<TEntidade>().Find(id);

        public List<TEntidade> Selecionar(string Uri, string param)
        {
            throw new NotImplementedException();
        }
    }
}

