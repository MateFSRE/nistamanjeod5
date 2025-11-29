using Microsoft.EntityFrameworkCore;

namespace ZooWeb.Data
{
    public class ZooDbContext : DbContext
    {
        public ZooDbContext(DbContextOptions<ZooDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vrsta> Vrste { get; set; }
        public DbSet<Zooloski> Zooloski { get; set; }
        public DbSet<Nastamba> Nastambe { get; set; }
        public DbSet<Jedinka> Jedinke { get; set; }
        public DbSet<Skupina> Skupine { get; set; }
        public DbSet<Obrazovanje> Obrazovanja { get; set; }
        public DbSet<Radnik> Radnici { get; set; }
        public DbSet<Obaveza> Obaveze { get; set; }
        public DbSet<Raspored> Rasporedi { get; set; }
        public DbSet<Tura> Ture { get; set; }
        public DbSet<Incident> Incidenti { get; set; }
        public DbSet<IncidentNastamba> IncidentNastambe { get; set; }
        public DbSet<IncidentZivotinja> IncidentZivotinje { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IncidentNastamba>()
                .HasKey(x => new { x.ID_incidenta, x.ID_nastambe });

            modelBuilder.Entity<IncidentZivotinja>()
                .HasKey(x => new { x.ID_incidenta, x.ID_vrste });

            base.OnModelCreating(modelBuilder);
        }
    }
}


