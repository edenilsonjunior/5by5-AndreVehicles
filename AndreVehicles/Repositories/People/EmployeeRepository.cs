using Microsoft.Data.SqlClient;
using Models.People;
using System.Configuration;

namespace Repositories.People;

public class EmployeeRepository
{
    private string _connectionString;

    public EmployeeRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;

    }

    public bool Insert(Employee employee) => UtilsRepository<Employee>.Insert(Employee.INSERT, employee);


    public List<Employee> GetAll()
    {
        var list = new List<Employee>();

        foreach (var row in UtilsRepository<dynamic>.GetAll(Employee.SELECT))
        {
            Address address = new Address(row.Street, row.PostalCode, row.District, row.StreetType, row.AdditionalInfo, row.Number, row.State, row.City);
            Role role = new Role(row.RoleDescription);
            Employee employee = new Employee(row.Document, row.Name, row.BirthDate, address, row.Phone, row.Email, role, row.CommissionValue, row.Commission);

            list.Add(employee);
        }

        return list;
    }
}
