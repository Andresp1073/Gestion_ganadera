using Data;
using Model;

namespace Logic;

public class VeterinarianLog
{
    public List<VeterinariansEntity> VeterinarianList()
    {
        using (var db = new RanchMasterContext())
        {
            return db.Veterinarians.ToList();
        }
    }

    public void UpdateVeterians(VeterinariansEntity objveterinarian)
    {
        using (var db = new RanchMasterContext())
        {
            db.Veterinarians.Update(objveterinarian);
            db.SaveChanges();
        }
    }
    public void CreateVeterinarian(VeterinariansEntity objveterinarian)
    {
        using (var db = new RanchMasterContext())
        {
            db.Veterinarians.Add(objveterinarian);
            db.SaveChanges();
        }
    }
}
