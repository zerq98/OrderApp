using OrderApp.Domain.Entity;
using OrderApp.Infrastructure.Migrations;
using System.Data.Entity;

namespace OrderApp.Infrastructure
{
    /// <summary>
    /// EntityFramework database context. Used to execute database action
    /// </summary>
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public AppDbContext() : base("OrderAppDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AppDbContext, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasRequired(i => i.Order)
                .WithMany(i => i.Products)
                .HasForeignKey(i => i.OrderId)
                .WillCascadeOnDelete(true);
        }
    }
}