using Models.Sales;
using System.Configuration;

namespace Repositories.Sales;

public class CardRepository
{
    private string _connectionString;

    public CardRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }

    public int Insert(Card card) => UtilsRepository<Card>.InsertWithScalar(Card.INSERT, card);

    public List<Card> GetAll() => UtilsRepository<Card>.GetAll(Card.SELECT);
}
