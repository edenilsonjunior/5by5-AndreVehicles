using Models.Cars;
using System.Configuration;

namespace Repositories.Cars;

public class OperationRepository
{
    private string _connectionString;

    public OperationRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }

    public int Insert(Operation operation)
    {
        object obj = new
        {
            operation.Description
        };

        return UtilsRepository<Operation>.InsertWithScalar(Operation.INSERT, obj);
    }

    public List<Operation> GetAll() => UtilsRepository<Operation>.GetAll(Operation.SELECT);

}
