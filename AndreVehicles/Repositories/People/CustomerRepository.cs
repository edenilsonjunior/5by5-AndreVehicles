using Models.People;
using System.Configuration;

namespace Repositories.People;

public class CustomerRepository
{
    private string _connectionString;

    public CustomerRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }

    public bool Insert(Customer costumer) => UtilsRepository<Customer>.Insert(Customer.INSERT, costumer);

    public List<Customer> GetAll()
    {
        var list = new List<Customer>();

        foreach (var row in UtilsRepository<dynamic>.GetAll(Customer.SELECT))
        {
            Address address = new (row.Street, row.PostalCode, row.District, row.StreetType, row.AdditionalInfo, row.Number, row.State, row.City);
            Customer customer = new (row.Document, row.Name, row.BirthDate, address, row.Phone, row.Email, row.Income);
            
            list.Add(customer);
        }

        return list;
    }
}
