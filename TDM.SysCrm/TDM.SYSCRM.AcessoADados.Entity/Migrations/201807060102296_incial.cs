namespace TDM.SysCRM.AcessoADados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class incial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assinante",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Cnpj = c.String(maxLength: 18),
                        RazaoSocial = c.String(nullable: false, maxLength: 100),
                        NomeDeFantasia = c.String(maxLength: 100),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Potencial",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        TPPessoa = c.Int(nullable: false),
                        CpfCnpj = c.String(maxLength: 18),
                        Email = c.String(maxLength: 150),
                        WhatsApp = c.String(maxLength: 14),
                        FoneCom = c.String(maxLength: 14),
                        FoneRes = c.String(maxLength: 14),
                        Celular = c.String(maxLength: 14),
                        Instagram = c.String(maxLength: 150),
                        Facebook = c.String(maxLength: 150),
                        Canal = c.Int(),
                        Cep = c.String(maxLength: 10),
                        Uf = c.Int(),
                        Nomedocontato = c.String(maxLength: 60),
                        Datadecadastro = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IdAssinante = c.Long(nullable: false),
                        IdConsultor = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Assinante", t => t.IdAssinante, cascadeDelete: true)
                .Index(t => t.IdAssinante);
            
            CreateTable(
                "dbo.MotivoAcionamen",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Potencial", "AssinanteId", "dbo.Assinante");
            DropIndex("dbo.Potencial", new[] { "AssinanteId" });
            DropTable("dbo.MotivoAcionamen");
            DropTable("dbo.Potencial");
            DropTable("dbo.Assinante");
        }
    }
}
