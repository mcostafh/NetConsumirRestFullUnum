using System.Data.Entity.ModelConfiguration;
using TDM.SysCRM.Dominio;

namespace TDM.Comum.Entity
{
    public abstract class TDMEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : Entidade
    {
        protected TDMEntityAbstractConfig()
        {
            HasKey(pk => pk.Id);
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("ID");

            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrimaria();
            ConfigurarChavesestrangeiras();
        }

        protected abstract void ConfigurarNomeTabela();
        protected abstract void ConfigurarCamposTabela();
        protected abstract void ConfigurarChavePrimaria();
        protected abstract void ConfigurarChavesestrangeiras();
    }
}
