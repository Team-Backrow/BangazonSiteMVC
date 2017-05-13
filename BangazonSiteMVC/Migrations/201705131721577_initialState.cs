namespace BangazonSiteMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialState : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.OrderLineItems",
                c => new
                    {
                        OrderLineItemId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderLineItemId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.Order_OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        PaymentType_PaymentTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentType_PaymentTypeId)
                .Index(t => t.PaymentType_PaymentTypeId);
            
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        PaymentTypeId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CardType = c.String(),
                    })
                .PrimaryKey(t => t.PaymentTypeId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductType = c.Int(nullable: false),
                        ProductName = c.String(),
                        Description = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "PaymentType_PaymentTypeId", "dbo.PaymentTypes");
            DropForeignKey("dbo.OrderLineItems", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Customers", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "PaymentType_PaymentTypeId" });
            DropIndex("dbo.OrderLineItems", new[] { "Order_OrderId" });
            DropIndex("dbo.Customers", new[] { "Customer_Id" });
            DropTable("dbo.Products");
            DropTable("dbo.PaymentTypes");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderLineItems");
            DropTable("dbo.Customers");
        }
    }
}
