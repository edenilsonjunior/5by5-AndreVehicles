using Models.Sales;
using System.Configuration;

namespace Repositories.Sales;

public class PaymentRepository
{
    private string _connectionString;

    public PaymentRepository()
    {
        _connectionString = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
    }

    public int Insert(Payment payment)
    {
        object obj = new
        {
            CardNumber = payment.Card.CardNumber,
            BankSlipId = payment.BankSlip.Id,
            PixId = payment.Pix.Id,
            PaymentDate = payment.PaymentDate
        };

        return UtilsRepository<Payment>.InsertWithScalar(Payment.INSERT, payment);
    }

    public List<Payment> GetAll()
    {
        var list = new List<Payment>();

        foreach (var row in UtilsRepository<dynamic>.GetAll(Payment.SELECT))
        {
            Card? card = null;
            Pix? pix = null;
            BankSlip? bankSlip = null;

            if (row.CardNumber != null)
                card = new(row.CardNumber, row.SecurityCode, row.ExpirationDate, row.CardHolderName);

            if(row.BankSlipId != null)
                bankSlip = new(row.BankSlipId, row.BankSlipNumber, row.BankSlipDueDate);

            if (row.PixId != null)
            {
                pix = new()
                {
                    Id = row.PixId,
                    PixKey = row.PixKey,
                    Type = new()
                    {
                        Id = row.PixTypeId,
                        Name = row.PixTypeName
                    }
                };
            }

            var payment = new Payment(row.Id, card, bankSlip, pix, row.PaymentDate);
            list.Add(payment);
        }
        return list;
    }
}
