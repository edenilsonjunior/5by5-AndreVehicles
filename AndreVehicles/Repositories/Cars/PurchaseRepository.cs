using Models.Cars;
using System.Configuration;

namespace Repositories.Cars;

public class PurchaseRepository
{
    private string _connectionString;

    public PurchaseRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }

    public bool Insert(Purchase purchase)
    {
        object obj = new
        {
            CarPlate = purchase.Car.Plate,
            purchase.Price,
            purchase.PurchaseDate
        };

        return UtilsRepository<Purchase>.Insert(Purchase.INSERT, obj);
    }

    public List<Purchase> GetAll() 
    {
        var list = new List<Purchase>();

        foreach (var row in UtilsRepository<dynamic>.GetAll(Purchase.SELECT))
        {
            Car c = new()
            {
                Plate = row.Plate,
                Name = row.Name,
                YearManufacture = row.YearManufacture,
                YearModel = row.YearModel,
                Color = row.Color,
                Sold = row.Sold
            };

            var p = new Purchase()
            {
                Id = row.PurchaseId,
                Car = c,
                Price = row.PurchacePrice,
                PurchaseDate = row.PurchaseDate
            };
            list.Add(p);
        }
        return list;
    } 
}
