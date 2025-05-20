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
                .Include(a => a.Race) // Incluye la información de la raza
                .ToList();
        }
    }


    public void UpdateAnimals(AnimalsEntity objAnimals)
    {
        using (var db = new RanchMasterContext())
        {
            db.Animals.Update(objAnimals);
            db.SaveChanges();
        }
    }
    
}