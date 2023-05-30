using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace DBData
{
    public class MyDbContext:DbContext
    {
        public DbSet<Market> Markets { get; set; }
        public DbSet<Product> Products { get; set; }

        public MyDbContext()
        {
          Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GRANDST;Database=Market;User Id=sa;Password=SaSa111; TrustServerCertificate = true");
        }

    }
}