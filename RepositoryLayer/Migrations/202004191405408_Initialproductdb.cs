namespace RepositoryLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialproductdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        ProductImage = c.String(),
                        ProductQuantity = c.Int(nullable: false),
                        ProductPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
