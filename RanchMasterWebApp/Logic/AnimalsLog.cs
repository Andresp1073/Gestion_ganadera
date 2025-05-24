using Data;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Logic;

public class AnimalsLog
{
    public static void CreateAnimals(AnimalsEntity objAnimals)
    {
        using (var db = new RanchMasterContext())
        {
            db.Animals.Add(objAnimals);
            db.SaveChanges();   
        }
    }

    public List<AnimalsEntity> AnimalsList()
    {
        using (var db = new RanchMasterContext())
        {
            return db.Animals
                .Include(a => a.Race)
                .Include(a => a.Location)
                .Include(a => a.Schedule)
                .Include(a => a.Reproduction)
                .ToList();
        }
    }


    public void UpdateAnimals(AnimalsEntity objAnimals)
    {
        using (var db = new RanchMasterContext())
        {
            var existingAnimal = db.Animals.FirstOrDefault(a => a.IdAnimal == objAnimals.IdAnimal);
            if (existingAnimal != null)
            {
                existingAnimal.Gender = objAnimals.Gender;
                existingAnimal.Age = objAnimals.Age;
                existingAnimal.Status = objAnimals.Status;
                existingAnimal.IdRace = objAnimals.IdRace;
                existingAnimal.IdLocation = objAnimals.IdLocation;
                existingAnimal.IdSchedule = objAnimals.IdSchedule;
                existingAnimal.IdReproduction = objAnimals.IdReproduction;

                db.SaveChanges();
            }
        }
    }
    
}