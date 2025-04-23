using Data;
using Model;

namespace Logic;

public class LocationsLog
{
    public List<LocationsEntity> LocationsList()
    {
        using (var db = new RanchMasterContext())
        {
            return db.Locations.ToList();
        }
    }

    public void Update(LocationsEntity objlocations)
    {
        using (var db = new  RanchMasterContext())
        {
         db.Locations.Update(objlocations);  
         db.SaveChanges();
        }
    }
    
    public void CreateLocations(LocationsEntity objlocations)
    {
        using (var db = new  RanchMasterContext())
        {
            db.Locations.Add(objlocations);  
            db.SaveChanges();
        }
    }
}