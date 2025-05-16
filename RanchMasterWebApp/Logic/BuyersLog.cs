using Data;
using Model;

namespace Logic;

public class BuyersLog
{
    public static List<BuyersEntity> BuyersList()
    {
        using (var db = new RanchMasterContext())
        {
            return db.Buyers.ToList();
        }
    }

    public static void  UpdateBuyers(BuyersEntity objbuyers)
    {
        using (var db = new RanchMasterContext())
        {
            db.Buyers.Update(objbuyers);
            db.SaveChanges();
        }
    }

    public static void CreateBuyers(BuyersEntity objbuyers)
    {
        using (var db = new RanchMasterContext())
        {
            db.Buyers.Add(objbuyers);
            db.SaveChanges();
        }
    }
}