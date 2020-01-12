namespace CRM.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRMModelShopDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Checks",
                c => new
                    {
                        CheckID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        SellerID = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CheckID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.SellerID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.SellerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        SellerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SellerID);
            
            CreateTable(
                "dbo.Sells",
                c => new
                    {
                        SellID = c.Int(nullable: false, identity: true),
                        CheckID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SellID)
                .ForeignKey("dbo.Checks", t => t.CheckID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.CheckID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sells", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Sells", "CheckID", "dbo.Checks");
            DropForeignKey("dbo.Checks", "SellerID", "dbo.Sellers");
            DropForeignKey("dbo.Checks", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Sells", new[] { "ProductID" });
            DropIndex("dbo.Sells", new[] { "CheckID" });
            DropIndex("dbo.Checks", new[] { "SellerID" });
            DropIndex("dbo.Checks", new[] { "CustomerID" });
            DropTable("dbo.Products");
            DropTable("dbo.Sells");
            DropTable("dbo.Sellers");
            DropTable("dbo.Customers");
            DropTable("dbo.Checks");
        }
    }
}
