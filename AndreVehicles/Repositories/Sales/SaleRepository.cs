using Models.Sales;
using Repositories.Cars;
using Repositories.People;
using System.Configuration;

namespace Repositories.Sales;

public class SaleRepository
{
    private string _connectionString;

    public SaleRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }

    public bool Insert(Sale sale)
    {
        object obj = new
        {
            CustomerDocument = sale.Customer.Document,
            EmployeeDocument = sale.Employee.Document,
            CarPlate = sale.Car.Plate,
            PaymentId = sale.Payment.Id,
            SaleDate = sale.SaleDate,
            SalePrice = sale.SalePrice
        };
    
        return UtilsRepository<Sale>.Insert(Sale.INSERT, sale);
    }

    public List<Sale> GetAll()
    {
        var customerList = new CustomerRepository().GetAll();
        var employeeList = new EmployeeRepository().GetAll();
        var paymentList = new PaymentRepository().GetAll();
        var carList = new CarRepository().GetAll();
        
        var list = new List<Sale>();
        foreach (var row in UtilsRepository<dynamic>.GetAll(Sale.SELECT))
        {
            var car = carList.Find(c => c.Plate == row.CarPlate);
            var customer = customerList.Find(c => c.Document == row.CustomerDocument);
            var employee = employeeList.Find(e => e.Document == row.EmployeeDocument);
            var payment = paymentList.Find(p => p.Id == row.PaymentId);

            var sale = new Sale()
            {
                Id = row.Id,
                Customer = customer,
                Employee = employee,
                Car = car,
                Payment = payment,
                SaleDate = row.SaleDate,
                SalePrice = row.SalePrice
            };
            list.Add(sale);
        }

        return list;
    }

}
