namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LojaId = c.Int(nullable: false),
                        Nome = c.String(),
                        Idade = c.Int(nullable: false),
                        Profissao = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lojas", t => t.LojaId, cascadeDelete: true)
                .Index(t => t.LojaId);
            
            CreateTable(
                "dbo.Lojas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Endereco = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "LojaId", "dbo.Lojas");
            DropIndex("dbo.Clientes", new[] { "LojaId" });
            DropTable("dbo.Lojas");
            DropTable("dbo.Clientes");
        }
    }
}
