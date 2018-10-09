using Microsoft.EntityFrameworkCore;
using siwp_app.Models;

namespace siwp_app.Models {
    public class SiwpContext : DbContext {
        public SiwpContext (DbContextOptions<SiwpContext> options) : base (options) {

        }
        public DbSet<Supplies> Supply { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Jobs> Job { get; set; }
        

    }
}