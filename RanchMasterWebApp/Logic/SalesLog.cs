using Data;
using Model;

namespace Logic;

public class SalesLog
{
    public List<SalesEntity> SalesList()
    {
        using (var db = new RanchMasterContext())
        {
            return db.Sales.ToList();
        }
    }

    public void UpdateSales(SalesEntity objsales)
    {
        using (var db = new RanchMasterContext())
        {
            db.Sales.Update(objsales);
            db.SaveChanges();
        }
    }

    public void CreateSales(SalesEntity objsales)
    {
        using (var db = new RanchMasterContext())
        {
            db.Sales.Add(objsales);
            db.SaveChanges();
        }
    }
}