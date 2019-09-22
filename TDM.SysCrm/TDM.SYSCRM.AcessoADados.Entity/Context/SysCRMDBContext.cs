using System.Data.Entity;

using TDM.SysCRM.Dominio;

namespace TDM.SysCRM.AcessoADados.Entity.Context
{
    public class SysCRMDBContext : DbContext
    {


        public SysCRMDBContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }

        public System.Data.Entity.DbSet<TDM.SysCRM.Dominio.Veiculo> Veiculoes { get; set; }
    }
}
