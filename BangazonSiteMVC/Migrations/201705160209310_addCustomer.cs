namespace BangazonSiteMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCustomer : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.PaymentTypes", "CustomerId");
            AddForeignKey("dbo.PaymentTypes", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaymentTypes", "CustomerId", "dbo.Customers");
            DropIndex("dbo.PaymentTypes", new[] { "CustomerId" });
        }
    }
}
