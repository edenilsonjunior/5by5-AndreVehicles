using Models.Sales;
using System.Configuration;

namespace Repositories.Sales;

public class PixRepository
{
    private string _connectionString;

    public PixRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }

    public int Insert(Pix pix)
    {
        string queryPixType = "INSERT INTO PixType(Name) VALUES(@Name); SELECT CAST(SCOPE_IDENTITY() AS INT);";

        int idPixType = UtilsRepository<PixType>.InsertWithScalar(queryPixType, pix.Type);

        object obj = new
        {
            Type = idPixType,
            PixKey = pix.PixKey
        };

        return UtilsRepository<Pix>.InsertWithScalar(Pix.INSERT, pix);
    }


    public List<Pix> GetAll()
    {
        var list = new List<Pix>();

        foreach (var item in UtilsRepository<dynamic>.GetAll(Pix.SELECT))
        {
            var pix = new Pix()
            {
                Id = item.Id,
                PixKey = item.PixKey,
                Type = new PixType()
                {
                    Id = item.PixTypeId,
                    Name = item.PixTypeName
                }
            };
            list.Add(pix);
        }

        return list;
    }
}
