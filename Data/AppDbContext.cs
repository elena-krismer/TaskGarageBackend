using Microsoft.EntityFrameworkCore;
using TaskGarageBackend.Models;

namespace TaskGarageBackend.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<WorkOrder> WorkOrders { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkOrder>()
                .OwnsOne(w => w.VehicleInfo);
        }
    }
}