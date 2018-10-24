namespace EFProjectSalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        PersonId = c.Int(nullable: false),
                        RegionId = c.Int(nullable: false),
                        CreatedByUser = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedByUser = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.SalesPersons", t => t.PersonId)
                .ForeignKey("dbo.SalesRegions", t => t.RegionId)
                .Index(t => t.PersonId)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.SalesPersons",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        IsActive = c.Boolean(nullable: false),
                        CreatedByUser = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedByUser = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        SalesRegion_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.SalesRegions", t => t.SalesRegion_id)
                .Index(t => t.SalesRegion_id);
            
            CreateTable(
                "dbo.SalesRegions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Code = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedByUser = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedByUser = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesPersons", "SalesRegion_id", "dbo.SalesRegions");
            DropForeignKey("dbo.Sales", "RegionId", "dbo.SalesRegions");
            DropForeignKey("dbo.Sales", "PersonId", "dbo.SalesPersons");
            DropIndex("dbo.SalesPersons", new[] { "SalesRegion_id" });
            DropIndex("dbo.Sales", new[] { "RegionId" });
            DropIndex("dbo.Sales", new[] { "PersonId" });
            DropTable("dbo.SalesRegions");
            DropTable("dbo.SalesPersons");
            DropTable("dbo.Sales");
        }
    }
}
