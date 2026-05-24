using Microsoft.EntityFrameworkCore;
using Model;


namespace Data;

public class RanchMasterContext : DbContext
{
    public DbSet<AnimalsEntity> Animals { get; set; }
    public DbSet<BuyersEntity> Buyers { get; set; }
    public DbSet<FeedingDetailsEntity> FeedingDetails { get; set; }
    public DbSet<FeedingSchedulesEntity> FeedingSchedules { get; set; }
    public DbSet<HealthsRecordsEntity> HealthsRecords { get; set; }
    public DbSet<LocationsEntity> Locations { get; set; }
    public DbSet<RacesEntity> Races { get; set; }
    public DbSet<ReproductionsEntity> Reproductions { get; set; }
    public DbSet<SalesEntity> Sales { get; set; }
    public DbSet<VeterinariansEntity> Veterinarians { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            connectionString: "server=localhost; user=root; password=123456789; port=3306; database=RanchMasterDB;",
            new MySqlServerVersion(new Version(8, 0, 34))
        );
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<RacesEntity>().HasData(
            new RacesEntity { IdRace  = 1, Name = "Cebu", Description = "Pequeña" }
        );

    }
}    


    


    
        
        
    
