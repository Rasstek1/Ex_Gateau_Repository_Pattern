using Microsoft.EntityFrameworkCore;

namespace Ex_Gateau_Repository_Pattern.Models
{
    public class GateauDbContext : DbContext
    {
        public GateauDbContext(DbContextOptions<GateauDbContext> options) : base(options)
        {
        }

        public DbSet<Gateau> Gateaux { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
    }
}
