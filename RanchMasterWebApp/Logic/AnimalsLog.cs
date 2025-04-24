using Data;
using Model;

namespace Logic;

public class AnimalsLog
{
    public void CreateAnimals(AnimalsEntity objAnimals)
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
            return db.Animals.ToList();
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