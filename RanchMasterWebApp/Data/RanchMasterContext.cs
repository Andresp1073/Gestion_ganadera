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

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<RacesEntity>().HasData(
            new RacesEntity { IdRace  = 1, Name = "Cebu", Description = "Pequeña" }
        );

    }
}    


    


    
        
        
    
