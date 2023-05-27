using examproject3.Models;
using Microsoft.EntityFrameworkCore;

public class webshopContext : DbContext
{

    public DbSet<Cart> Cart { get; set; }
    public DbSet<Orderline> Orderline { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Subproduct> Subproduct { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("server=localhost;database=webshop;user=root;password=");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.cartID);
        });

        modelBuilder.Entity<Orderline>(entity =>
        {
            entity.HasKey(e => e.orderlineID);
            entity.Property(e => e.amount).IsRequired();
            entity.HasOne(e => e.Cart)
                  .WithMany(c => c.Orderlines);
            entity.HasOne(e => e.Subproduct)
                  .WithMany(b => b.Orderlines);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.productID);
            entity.Property(e => e.price).IsRequired();
            entity.Property(e => e.description).IsRequired();
        });

        modelBuilder.Entity<Subproduct>(entity =>
        {
            entity.HasKey(e => e.subproductID);
            entity.Property(e => e.stock).IsRequired();
            entity.Property(e => e.size).IsRequired();
            entity.HasOne(e => e.Product)
                  .WithMany(c => c.Subproducts);
        });
    }

}
    