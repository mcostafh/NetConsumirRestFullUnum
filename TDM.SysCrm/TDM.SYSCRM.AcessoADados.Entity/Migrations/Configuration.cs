namespace TDM.SysCRM.AcessoADados.Entity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TDM.SysCRM.Dominio;

    internal sealed class Configuration : DbMigrationsConfiguration<TDM.SysCRM.AcessoADados.Entity.Context.SysCRMDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed( SysCRM.AcessoADados.Entity.Context.SysCRMDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //context.Assinantes.AddOrUpdate( x => x.Id,
            //    new Assinante() { NomeDeFantasia="Handara", RazaoSocial="Maverick"  } );

          

            context.SaveChanges();
        }
    }
}
