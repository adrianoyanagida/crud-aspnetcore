using Microsoft.EntityFrameworkCore;

namespace CRUDASP.NETMVA
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}