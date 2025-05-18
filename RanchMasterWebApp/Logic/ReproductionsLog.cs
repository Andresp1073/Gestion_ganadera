using Data;
using Model;

namespace Logic;

public class ReproductionsLog
{
    public List<ReproductionsEntity> ReproductionsList()
    {
        using (var db = new RanchMasterContext())
        {
            return db.Reproductions.ToList();
        }
    }

    public void UpdateReproductions(ReproductionsEntity objReproduction)
    {
        using (var db = new RanchMasterContext())
        {
            db.Reproductions.Update(objReproduction);
            db.SaveChanges();
        }
    }

    public static void CreateReproductions(ReproductionsEntity objReproduction)
    {
        using (var db = new RanchMasterContext())
        {
            db.Reproductions.Add(objReproduction);
            db.SaveChanges();
        }
    }
}