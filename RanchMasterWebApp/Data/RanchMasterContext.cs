using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Identity;

namespace Data;

public class RanchMasterContext : IdentityDbContext<ApplicationUser>
{
    public RanchMasterContext()
    {
    }

    public RanchMasterContext(DbContextOptions<RanchMasterContext> options)
        : base(options)
    {
    }

    public DbSet<AnimalsEntity> Animals { get; set; } = null!;
    public DbSet<BuyersEntity> Buyers { get; set; } = null!;
    public DbSet<FeedingDetailsEntity> FeedingDetails { get; set; } = null!;
    public DbSet<FeedingSchedulesEntity> FeedingSchedules { get; set; } = null!;
    public DbSet<HealthsRecordsEntity> HealthsRecords { get; set; } = null!;
    public DbSet<LocationsEntity> Locations { get; set; } = null!;
    public DbSet<RacesEntity> Races { get; set; } = null!;
    public DbSet<ReproductionsEntity> Reproductions { get; set; } = null!;
    public DbSet<SalesEntity> Sales { get; set; } = null!;
    public DbSet<VeterinariansEntity> Veterinarians { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connStr = Environment.GetEnvironmentVariable("MYSQL_CONNECTION_STRING")
                ?? "server=localhost;user=root;password=1234567890;port=3306;database=RanchMasterDB;";
            optionsBuilder.UseMySql(
                connStr,
                new MySqlServerVersion(new Version(8, 0, 34))
            );
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<RacesEntity>().HasData(
            new RacesEntity
            {
                IdRace = 1,
                Name = "Cebu",
                Description = "Pequeña"
            }
        );
    }
}