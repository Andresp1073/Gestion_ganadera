using Data;
using Model;

namespace Logic;

public static class VeterinariansLog
{
    public static List<VeterinariansEntity> VeterinarianList()
    {
        using (var db = new RanchMasterContext())
        {
            return db.Veterinarians.ToList();
        }
    }

    public static void UpdateVeterinarians(VeterinariansEntity objveterinarian)
    {
        using (var db = new RanchMasterContext())
        {
            db.Veterinarians.Update(objveterinarian);
            db.SaveChanges();
        }
    }
    public static void CreateVeterinarian(VeterinariansEntity objveterinarian)
    {
        using (var db = new RanchMasterContext())
        {
            db.Veterinarians.Add(objveterinarian);
            db.SaveChanges();
        }
    }
}
