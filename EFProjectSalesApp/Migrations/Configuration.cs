namespace EFProjectSalesApp.Migrations
{
    using System;
    using EFProjectSalesApp.Model_Entity;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFProjectSalesApp.Data.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFProjectSalesApp.Data.SalesContext context)
        {
            context.SalesRegions.AddOrUpdate(
                p => p.id,
                new SalesRegion
                {
                    IsActive = true,
                    Code = "NTH",
                    CreatedByUser = "Admin",
                    CreatedDate = DateTime.Now,
                    id = 1000,
                    Name = "North Region",
                    SalesTarget = 20000.00M,
                    UpdatedByUser = "Admin",
                    UpdatedDate = DateTime.Now
                },
                new SalesRegion
                {
                    IsActive = true,
                    Code = "STH",
                    CreatedByUser = "Admin",
                    CreatedDate = DateTime.Now,
                    id = 1001,
                    Name = "South Region",
                    SalesTarget = 20000.00M,
                    UpdatedByUser = "Admin",
                    UpdatedDate = DateTime.Now
                }
             );

                context.SalesPeople.AddOrUpdate(
                p  => p.id,
                new SalesPerson
                {
                    IsActive = true,
                    CreatedByUser = "Admin",
                    CreatedDate = DateTime.Now,
                    id = 1000,
                    FirstName = "Hoshidan",
                    LastName = "Ryoma",
                    SalesTarget = 1000.00M,
                    UpdatedByUser = "Admin",
                    UpdatedDate = DateTime.Now,
                    
                }
            );
            context.Sales.AddOrUpdate
            (
                new Sale
                {
                    Amount = 355.25M,
                    CreatedByUser = "Amdin",
                    CreatedDate = DateTime.Now,
                    Date = new DateTime(2018,5,5),
                    PersonId = 1000,
                    RegionId = 1000,
                    UpdatedDate = DateTime.Now
                }
             );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
