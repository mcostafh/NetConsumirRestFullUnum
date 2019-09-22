namespace TDM.SysCRM.AcessoADados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConsultorRecebeLeads : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Consultor", "RecebeDistribuicaoLeads", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Consultor", "RecebeDistribuicaoLeads");
        }
    }
}
