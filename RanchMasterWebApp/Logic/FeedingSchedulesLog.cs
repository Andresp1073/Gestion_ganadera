using Data;
using Model;

namespace Logic;

public class FeedingSchedulesLog
{
    public void CreateFeedingSheduleLog(FeedingSchedulesEntity objFeedingSheduleLog)
    {
        using (var db = new RanchMasterContext())
        {
            db.FeedingSchedules.Add(objFeedingSheduleLog);
            db.SaveChanges();
        }
    }

    public List<FeedingSchedulesEntity> FeedingSchedulesList()
    {
        using (var db = new RanchMasterContext())
        {
            return db.FeedingSchedules.ToList();
        }
    }

    public void UpdateFeedingSchedules(FeedingSchedulesEntity objFeedingSchedulesEntity)
    {
        using (var db = new RanchMasterContext())
        {
            db.FeedingSchedules.Update(objFeedingSchedulesEntity);
            db.SaveChanges();
        }
    }
}