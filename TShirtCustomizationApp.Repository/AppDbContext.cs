using Microsoft.EntityFrameworkCore;
using TShirtCustomizationApp.Entity;

namespace TShirtCustomizationApp.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<Item> _itemDbSet;
        public DbSet<Color> _colorDbSet;
        public DbSet<Fabric> _fabricDbSet;
        public DbSet<Image> _imageDbSet;
        public DbSet<ItemFabric> _itemFabricDbSet;
        public DbSet<ItemColor> _itemColorDbSet;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-FGQM066T\\SQLEXPRESS;Database=tsca_db;Integrated Security=True;TrustServerCertificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<Color>().ToTable("Color");
            modelBuilder.Entity<Fabric>().ToTable("Fabric");
            modelBuilder.Entity<Image>().ToTable("Image");
            modelBuilder.Entity<ItemFabric>().ToTable("ItemFabric");
            modelBuilder.Entity<ItemColor>().ToTable("ItemColor");
        }
    }
}
