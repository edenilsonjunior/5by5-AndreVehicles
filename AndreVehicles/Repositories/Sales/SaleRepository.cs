﻿using Models.Sales;
using System.Configuration;

namespace Repositories.Sales;

public class SaleRepository
{
    private string _connectionString;

    public SaleRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }

    public int Insert(Sale sale)
    {
        throw new NotImplementedException();
    }

    public List<Payment> GetAll()
    {
        throw new NotImplementedException();
    }

}
