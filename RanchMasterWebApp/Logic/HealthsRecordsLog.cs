using Data;
using Model;

namespace Logic;

public class HealthsRecordsLog
{
    
    public void CreateHealthRecords(HealthsRecordsEntity objHealthsRecords)
    {
        
        using (var db = new RanchMasterContext())
        {
            db.HealthsRecords.Add(objHealthsRecords);
            db.SaveChanges();   
        }
    }

    public List<HealthsRecordsEntity> HealthsRecordsList()
    {
        using (var db = new RanchMasterContext())
        {
            return db.HealthsRecords.ToList();
        }
    }

    public void UpdateHealthsRecords(HealthsRecordsEntity objHealthsRecords)
    {
        using (var db = new RanchMasterContext())
        {
            db.HealthsRecords.Update(objHealthsRecords);
            db.SaveChanges();
        }
    }
}