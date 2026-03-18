using Microsoft.EntityFrameworkCore;
using LogisticaAPI.Models;

namespace LogisticaAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // ==================== TUS DBSETS (agrega los que ya tenías) ====================
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        // Agrega aquí los demás: Product, Category, OrderItem, etc.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relación User <-> Role
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            // Relación User <-> Order (si Order tiene User)
            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}