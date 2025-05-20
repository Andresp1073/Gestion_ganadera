using Data;
using Model;

namespace Logic;

public class FeedingDetailsLog
{
    public static void CreateFeedingDetails(FeedingDetailsEntity objFeedingDetails)
    {
        using (var db = new RanchMasterContext())
        {
            db.FeedingDetails.Add(objFeedingDetails);
            db.SaveChanges();
        }
    }

    public List<FeedingDetailsEntity> FeedingDetailsList()
    {
        using (var db = new RanchMasterContext())
        {
            return db.FeedingDetails.ToList();
        }
    }

    public void UpdateRaces(FeedingDetailsEntity objFeedingDetails)
    {
        using (var db = new RanchMasterContext())
        {
            db.FeedingDetails.Update(objFeedingDetails);
            db.SaveChanges();
        }
    }
}