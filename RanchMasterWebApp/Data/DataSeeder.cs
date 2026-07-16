using Microsoft.EntityFrameworkCore;
using Model;

namespace Data;

public static class DataSeeder
{
    public static async Task SeedAsync(RanchMasterContext context)
    {
        if (await context.Animals.AnyAsync())
            return;

        var races = new List<RacesEntity>
        {
            new() { Name = "Holstein", Description = "Raza lechera de alta producción" },
            new() { Name = "Angus", Description = "Raza de carne de alta calidad" },
            new() { Name = "Brahman", Description = "Raza resistente al calor" },
        };
        context.Races.AddRange(races);
        await context.SaveChangesAsync();

        var locations = new List<LocationsEntity>
        {
            new() { Name = "Potrero Norte", Type = "Potrero", Capacity = 50 },
            new() { Name = "Potrero Sur", Type = "Potrero", Capacity = 40 },
            new() { Name = "Establo Central", Type = "Establo", Capacity = 30 },
            new() { Name = "Corral de Engorde", Type = "Corral", Capacity = 60 },
        };
        context.Locations.AddRange(locations);
        await context.SaveChangesAsync();

        var reproductions = new List<ReproductionsEntity>
        {
            new() { MatingDate = new DateTime(2025, 10, 15), NumberOffspring = 1, Status = "Completado", Birthdate = new DateTime(2026, 1, 20) },
            new() { MatingDate = new DateTime(2025, 12, 1), NumberOffspring = 1, Status = "Completado", Birthdate = new DateTime(2026, 3, 15) },
            new() { MatingDate = new DateTime(2026, 2, 10), NumberOffspring = 0, Status = "En gestación", Birthdate = new DateTime(2026, 5, 25) },
            new() { MatingDate = new DateTime(2026, 1, 5), NumberOffspring = 2, Status = "Completado", Birthdate = new DateTime(2026, 4, 10) },
        };
        context.Reproductions.AddRange(reproductions);
        await context.SaveChangesAsync();

        var feedingDetails = new List<FeedingDetailsEntity>
        {
            new() { Quantity = 200, FoodType = "Pasto de corte" },
            new() { Quantity = 150, FoodType = "Concentrado" },
            new() { Quantity = 100, FoodType = "Heno" },
            new() { Quantity = 300, FoodType = "Silaje de maíz" },
        };
        context.FeedingDetails.AddRange(feedingDetails);
        await context.SaveChangesAsync();

        var buyers = new List<BuyersEntity>
        {
            new() { Name = "Carlos Gutiérrez", Cc = "1234567890", PhoneNumber = "3001234567" },
            new() { Name = "María Fernanda López", Cc = "0987654321", PhoneNumber = "3109876543" },
            new() { Name = "Juan Pablo Restrepo", Cc = "1122334455", PhoneNumber = "3201122334" },
        };
        context.Buyers.AddRange(buyers);
        await context.SaveChangesAsync();

        var veterinarians = new List<VeterinariansEntity>
        {
            new() { Name = "Dr. Ricardo Méndez", Phone = "3156789012", Email = "ricardo.mendez@vet.com" },
            new() { Name = "Dra. Laura Castillo", Phone = "3167890123", Email = "laura.castillo@vet.com" },
        };
        context.Veterinarians.AddRange(veterinarians);
        await context.SaveChangesAsync();

        var feedingSchedules = new List<FeedingSchedulesEntity>
        {
            new() { FeedingTime = new DateTime(2026, 5, 29, 6, 0, 0), IdFeedingDetail = feedingDetails[0].IdFeedingDetail },
            new() { FeedingTime = new DateTime(2026, 5, 29, 12, 0, 0), IdFeedingDetail = feedingDetails[1].IdFeedingDetail },
            new() { FeedingTime = new DateTime(2026, 5, 29, 17, 0, 0), IdFeedingDetail = feedingDetails[2].IdFeedingDetail },
            new() { FeedingTime = new DateTime(2026, 5, 30, 6, 0, 0), IdFeedingDetail = feedingDetails[3].IdFeedingDetail },
        };
        context.FeedingSchedules.AddRange(feedingSchedules);
        await context.SaveChangesAsync();

        var animals = new List<AnimalsEntity>
        {
            new() { Gender = "M", Age = 3, Status = "Saludable", IdSchedule = feedingSchedules[0].IdSchedule, IdLocation = locations[0].IdLocation, IdReproduction = reproductions[0].IdBreeding, IdRace = races[0].IdRace },
            new() { Gender = "H", Age = 5, Status = "Saludable", IdSchedule = feedingSchedules[1].IdSchedule, IdLocation = locations[0].IdLocation, IdReproduction = reproductions[1].IdBreeding, IdRace = races[1].IdRace },
            new() { Gender = "M", Age = 2, Status = "En tratamiento", IdSchedule = feedingSchedules[2].IdSchedule, IdLocation = locations[1].IdLocation, IdReproduction = reproductions[2].IdBreeding, IdRace = races[2].IdRace },
            new() { Gender = "H", Age = 4, Status = "Saludable", IdSchedule = feedingSchedules[3].IdSchedule, IdLocation = locations[2].IdLocation, IdReproduction = reproductions[3].IdBreeding, IdRace = races[0].IdRace },
        };
        context.Animals.AddRange(animals);
        await context.SaveChangesAsync();

        var healthRecords = new List<HealthsRecordsEntity>
        {
            new() { Diagnosis = "Control sanitario de rutina", Treatment = "Desparasitación", IdVeterinarian = veterinarians[0].IdVeterinarian, Vaccines = "Triple bovina", IdAnimal = animals[0].IdAnimal },
            new() { Diagnosis = "Infección respiratoria leve", Treatment = "Antibiótico", IdVeterinarian = veterinarians[1].IdVeterinarian, Vaccines = "Ninguna", IdAnimal = animals[2].IdAnimal },
            new() { Diagnosis = "Revisión post-parto", Treatment = "Vitaminas", IdVeterinarian = veterinarians[0].IdVeterinarian, Vaccines = "Complejo B", IdAnimal = animals[1].IdAnimal },
        };
        context.HealthsRecords.AddRange(healthRecords);
        await context.SaveChangesAsync();

        var sales = new List<SalesEntity>
        {
            new() { SaleDateTime = new DateTime(2026, 5, 15, 14, 30, 0), IdBuyer = buyers[0].IdBuyer, IdAnimal = animals[0].IdAnimal },
            new() { SaleDateTime = new DateTime(2026, 5, 20, 10, 0, 0), IdBuyer = buyers[1].IdBuyer, IdAnimal = animals[2].IdAnimal },
        };
        context.Sales.AddRange(sales);
        await context.SaveChangesAsync();
    }
}
