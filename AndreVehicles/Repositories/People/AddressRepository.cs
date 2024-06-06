using Models.People;
using System.Configuration;

namespace Repositories.People;

public class AddressRepository
{
    private string _connectionString;

    public AddressRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }

    public int Insert(Address address) => UtilsRepository<Address>.InsertWithScalar(Address.INSERT, address);

    public List<Address> GetAll() => UtilsRepository<Address>.GetAll(Address.SELECT);
}
