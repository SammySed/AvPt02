namespace AvaliacaoPt02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Clientes",
            //    c => new
            //        {
            //            ClienteId = c.Long(nullable: false, identity: true),
            //            Nome = c.String(),
            //        })
            //    .PrimaryKey(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            //DropTable("dbo.Clientes");
        }
    }
}
