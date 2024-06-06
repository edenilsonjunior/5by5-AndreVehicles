using Models.Cars;
using System.Configuration;

namespace Repositories.Cars;

public class CarOperationRepository
{
    private string _connectionString;

    public CarOperationRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }

    public bool Insert(CarOperation carOperation)
    {
        object obj = new
        {
            CarPlate = carOperation.Car.Plate,
            OperationId = carOperation.Operation.Id
        };
        return UtilsRepository<CarOperation>.Insert(CarOperation.INSERT, obj);
    }


    public List<CarOperation> GetAll()
    {
        var list = new List<CarOperation>();

        foreach (var row in UtilsRepository<dynamic>.GetAll(CarOperation.SELECT))
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

            Operation o = new()
            {
                Id = row.OperationId,
                Description = row.Description
            };

            list.Add(new CarOperation
            {
                Id = row.CarOperationId,
                Car = c,
                Operation = o,
                Status = row.CarOperationStatus
            });
        }

        return list;
    }
}
