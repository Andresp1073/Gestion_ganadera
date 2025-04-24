using Data;
using Model;

namespace Logic;

public class BuyersLog
{
    public List<BuyersEntity> BuyersList()
    {
        using (var db = new RanchMasterContext())
        {
            return db.Buyers.ToList();
        }
    }

    public void UpdateBuyers(BuyersEntity objbuyers)
    {
        using (var db = new RanchMasterContext())
        {
            db.Buyers.Update(objbuyers);
            db.SaveChanges();
        }
    }

    public void CreateBuyers(SalesEntity objbuyers)
    {
        using (var db = new RanchMasterContext())
        {
            db.Sales.Add(objbuyers);
            db.SaveChanges();
        }
    }
}