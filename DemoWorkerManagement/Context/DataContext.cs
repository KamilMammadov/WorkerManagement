using Microsoft.EntityFrameworkCore;
using WorkerManagement.Models;

namespace WorkerManagement.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-466PC0V;Database=Workers;Trusted_Connection=True;TrustServerCertificate=True;"); 
        }
        public DbSet<Worker> Workers { get; set; }
    }
}
