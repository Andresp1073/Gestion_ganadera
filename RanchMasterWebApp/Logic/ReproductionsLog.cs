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

    public void UpdateReproductions(ReproductionsEntity objreproductions)
    {
        using (var db = new RanchMasterContext())
        {
            db.Reproductions.Update(objreproductions);
            db.SaveChanges();
        }
    }

    public void CreateReproductions(ReproductionsEntity objreproductions)
    {
        using (var db = new RanchMasterContext())
        {
            db.Reproductions.Add(objreproductions);
            db.SaveChanges();
        }
    }
}