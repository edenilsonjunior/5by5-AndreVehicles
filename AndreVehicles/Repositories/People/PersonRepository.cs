using Models.People;
using System.Configuration;

namespace Repositories.People;

public class PersonRepository
{
    private string _connectionString;

    public PersonRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }

    public int Insert(Person person) => UtilsRepository<Person>.InsertWithScalar(Person.INSERT, person);

}
