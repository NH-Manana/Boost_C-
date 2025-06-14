using Microsoft.EntityFrameworkCore;
using GVP.Models;

namespace GVP.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=client_wpf;Username=postgres;Password=yu");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(c => c.Telephone)
                .HasMaxLength(10);
        }
    }
}
