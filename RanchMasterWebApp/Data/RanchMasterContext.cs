using Microsoft.EntityFrameworkCore;

namespace Data;

public class RanchMasterContext : DbContext
{
    public RanchMasterContext(DbContextOptions<RanchMasterContext> options) : base(options) { }

    public RanchMasterContext()
    {
        throw new NotImplementedException();
    }

    // TIPOS TOTALMENTE CALIFICADOS con el namespace REAL de tus entidades
    public DbSet<Model.AnimalsEntity>          Animals          { get; set; } = null!;
    public DbSet<Model.BuyersEntity>           Buyers           { get; set; } = null!;
    public DbSet<Model.FeedingDetailsEntity>   FeedingDetails   { get; set; } = null!;
    public DbSet<Model.FeedingSchedulesEntity> FeedingSchedules { get; set; } = null!;
    public DbSet<Model.HealthsRecordsEntity>   HealthsRecords   { get; set; } = null!;
    public DbSet<Model.LocationsEntity>        Locations        { get; set; } = null!;
    public DbSet<Model.RacesEntity>            Races            { get; set; } = null!;
    public DbSet<Model.ReproductionsEntity>    Reproductions    { get; set; } = null!;
    public DbSet<Model.SalesEntity>            Sales            { get; set; } = null!;
    public DbSet<Model.VeterinariansEntity>    Veterinarians    { get; set; } = null!;

    // SIN OnConfiguring: la conexión se inyecta en Program.cs
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Model.RacesEntity>().HasData(
            new Model.RacesEntity { IdRace = 1, Name = "Cebu", Description = "Pequeña" }
        );
    }
}