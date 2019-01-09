using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModeloDDDContext : DbContext
    {
        public ProjetoModeloDDDContext() : base("ProjetoModeloDDD") { }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product>   Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) { }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("InsertAt") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("InsertAt").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("InsertAt").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }

}
