using DemoWorkerManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoWorkerManagement.Context
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
