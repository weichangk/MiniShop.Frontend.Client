using Microsoft.EntityFrameworkCore;
using Weick.Orm.Core;

namespace MiniShop.Frontend.Client.DbContexts
{
    public class AppDbContext : BaseDbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
            optionsBuilder.UseSqlite($@"DataSource={System.Environment.CurrentDirectory}\Data\Shop.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            //modelBuilder.Entity<Item>()
            //    .HasIndex(m => new { m.ShopId, m.Code })
            //    .IsUnique();
            //modelBuilder.Entity<Categorie>()
            //    .HasIndex(m => new { m.ShopId, m.Code })
            //    .IsUnique();
            //modelBuilder.Entity<Unit>()
            //    .HasIndex(m => new { m.ShopId, m.Code })
            //    .IsUnique();


            //modelBuilder.Seed();
        }

    }
}
