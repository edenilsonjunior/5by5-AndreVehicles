using Models.Sales;
using System.Configuration;

namespace Repositories.Sales;

public class BankSlipRepository
{
    private string _connectionString;

    public BankSlipRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }

    public int Insert(BankSlip bankSlip) => UtilsRepository<BankSlip>.InsertWithScalar(BankSlip.INSERT, bankSlip);

    public List<BankSlip> GetAll() => UtilsRepository<BankSlip>.GetAll(BankSlip.SELECT);
}
