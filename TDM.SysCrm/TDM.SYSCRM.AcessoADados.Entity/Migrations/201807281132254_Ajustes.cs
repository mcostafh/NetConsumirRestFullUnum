namespace TDM.SysCRM.AcessoADados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ajustes : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Potencial", "ConsultorId");
            AddForeignKey("dbo.Potencial", "ConsultorId", "dbo.Consultor", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Potencial", "ConsultorId", "dbo.Consultor");
            DropIndex("dbo.Potencial", new[] { "ConsultorId" });
        }
    }
}
