using Data;
using Model;

namespace Logic;

public static class SalesLog
{
    public static List<SalesEntity> SalesList()
    {
        using (var db = new RanchMasterContext())
        {
            return db.Sales.ToList();
        }
    }

    public static void UpdateSales(SalesEntity objsales)
    {
        using (var db = new RanchMasterContext())
        {
            db.Sales.Update(objsales);
            db.SaveChanges();
        }
    }

    public static void CreateSales(SalesEntity objsales)
    {
        using (var db = new RanchMasterContext())
        {
            db.Sales.Add(objsales);
            db.SaveChanges();
        }
    }
}