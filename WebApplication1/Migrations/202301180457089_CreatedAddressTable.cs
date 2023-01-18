namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedAddressTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        HouseNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        StreetName = c.String(maxLength: 50, unicode: false),
                        City = c.String(nullable: false, maxLength: 50, unicode: false),
                        AddressLine1 = c.String(nullable: false, maxLength: 50, unicode: false),
                        AddressLine2 = c.String(maxLength: 50, unicode: false),
                        FlatName = c.String(maxLength: 50, unicode: false),
                        PinCode = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.AddressId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Addresses");
        }
    }
}
