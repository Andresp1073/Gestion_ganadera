using Data;
using Model;

namespace Logic;

public class RacesLog
{
    public void CreateRaces(RacesEntity objRaces)
    {
        using (var db = new RanchMasterContext())
        {
            db.Races.Add(objRaces);
            db.SaveChanges();
        }
    }

    public List<RacesEntity> RacesList()
    {
        using (var db = new RanchMasterContext())
        {
            return db.Races.ToList();
        }
    }

    public void UpdateRaces(RacesEntity objRaces)
    {
        using (var db = new RanchMasterContext())
        {
            db.Races.Update(objRaces);
            db.SaveChanges();
        }
    }
}