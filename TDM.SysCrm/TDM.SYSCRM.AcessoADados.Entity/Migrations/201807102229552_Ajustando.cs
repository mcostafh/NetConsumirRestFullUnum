namespace TDM.SysCRM.AcessoADados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ajustando : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Potencial", "IdAssinante", "dbo.Assinante");
            DropIndex("dbo.Potencial", new[] { "IdAssinante" });
            RenameColumn(table: "dbo.Potencial", name: "IdAssinante", newName: "AssinanteId");
            AddColumn("dbo.Potencial", "ConsultorId", c => c.Long());
            AlterColumn("dbo.Potencial", "AssinanteId", c => c.Long());
            CreateIndex("dbo.Potencial", "AssinanteId");
            AddForeignKey("dbo.Potencial", "AssinanteId", "dbo.Assinante", "ID");
            DropColumn("dbo.Potencial", "IdConsultor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Potencial", "IdConsultor", c => c.Long());
            DropForeignKey("dbo.Potencial", "AssinanteId", "dbo.Assinante");
            DropIndex("dbo.Potencial", new[] { "AssinanteId" });
            AlterColumn("dbo.Potencial", "AssinanteId", c => c.Long(nullable: false));
            DropColumn("dbo.Potencial", "ConsultorId");
            RenameColumn(table: "dbo.Potencial", name: "AssinanteId", newName: "IdAssinante");
            CreateIndex("dbo.Potencial", "IdAssinante");
            AddForeignKey("dbo.Potencial", "IdAssinante", "dbo.Assinante", "ID", cascadeDelete: true);
        }
    }
}
