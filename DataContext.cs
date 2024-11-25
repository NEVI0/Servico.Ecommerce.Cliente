using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Cliente
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            base.OnModelCreating(modelBuilder);
        }
    }
}