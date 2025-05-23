using Data;
using Model;
using Microsoft.EntityFrameworkCore; // Necesitas agregar esta línea

namespace Logic;

public class HealthRecordsLog
{
    public static void CreateHealthRecords(HealthsRecordsEntity objHealthsRecords)
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
            // Carga explícitamente las entidades relacionadas (Veterinarians y Animals)
            return db.HealthsRecords
                .Include(hr => hr.Veterinarians) // Incluye el veterinario asociado
                .Include(hr => hr.Animals)      // Incluye el animal asociado
                .ToList();
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