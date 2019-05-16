using Microsoft.EntityFrameworkCore;

namespace Wolves.Models {
    public class WolfContext : DbContext {
        public WolfContext(DbContextOptions options) : base(options) { }
        public DbSet<Wolf> Wolves {get;set;}
    }
}
