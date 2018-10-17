using EFProjectSalesApp.Interfaces;
using EFProjectSalesApp.Model_Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjectSalesApp.Data
{
    class SalesContext : DbContext
    {
        public DbSet<Sale> Sales { get; set; }

        public DbSet<SalesPerson> SalesPeople { get; set; }

        public DbSet<SalesRegion> SalesRegions { get; set; }

        //Advanced features located below
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();  //removes cascading delete from Sales
            //When a sale gets deleted, the effect does not spread to the other tables

            
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();  //Makes sure EF has changes arranged

            //Do soft delete
            var stateManager = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager;

            var deletedEntities = stateManager.GetObjectStateEntries(EntityState.Deleted).Select(e => e.Entity).OfType<IActive>().ToArray();

            foreach(var deletedEntity in deletedEntities)
            {
                if (deletedEntities == null)
                    continue;
                stateManager.ChangeObjectState(deletedEntity, EntityState.Modified);
                deletedEntity.IsActive = false;
            }

            var createdEntities = stateManager.GetObjectStateEntries(EntityState.Added).Select(e => e.Entity).OfType<BaseModel>().ToArray();

            foreach(var createdEntity in createdEntities)
            {
                createdEntity.CreatedDate = DateTime.Now;
                createdEntity.CreatedByUser = Environment.UserName;
                createdEntity.UpdatedDate = DateTime.Now;
                createdEntity.UpdatedByUser = Environment.UserName;
            }

            var updatedEntities = stateManager.GetObjectStateEntries(EntityState.Modified).Select(e => e.Entity).OfType<BaseModel>().ToArray();

            foreach (var updatedEnt in updatedEntities)
            {
                updatedEnt.UpdatedDate = DateTime.Now;
                updatedEnt.UpdatedByUser = Environment.UserName;
            }

            return base.SaveChanges();
        }

    }
}
