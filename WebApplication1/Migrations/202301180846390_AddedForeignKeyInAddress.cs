namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignKeyInAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Addresses", "CustomerId");
            AddForeignKey("dbo.Addresses", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Addresses", new[] { "CustomerId" });
            DropColumn("dbo.Addresses", "CustomerId");
        }
    }
}
