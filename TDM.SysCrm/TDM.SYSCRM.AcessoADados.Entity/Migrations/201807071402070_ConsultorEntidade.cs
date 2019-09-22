namespace TDM.SysCRM.AcessoADados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConsultorEntidade : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consultor",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Consultor");
        }
    }
}
