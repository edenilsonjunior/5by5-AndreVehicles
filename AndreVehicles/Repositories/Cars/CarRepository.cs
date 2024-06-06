using Models.Cars;
using System.Configuration;

namespace Repositories.Cars;

public class CarRepository
{
    private string _connectionString;

    public CarRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }

    public bool Insert(Car car)
    {
        object obj = new
        {
            car.Plate,
            car.Name,
            car.YearManufacture,
            car.YearModel,
            car.Color,
            car.Sold
        };
        return UtilsRepository<Car>.Insert(Car.INSERT, obj);
    }

    public List<Car> GetAll() => UtilsRepository<Car>.GetAll(Car.SELECT);
}
