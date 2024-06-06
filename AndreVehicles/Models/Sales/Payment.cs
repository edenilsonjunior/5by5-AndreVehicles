namespace Models.Sales;


public class Payment
{
    public readonly static string INSERT = "INSERT INTO Payment(CardNumber, BankSlipId, PixId, PaymentDate) VALUES(@CardNumber, @BankSlipId, @PixId, @PaymentDate); SELECT CAST(SCOPE_IDENTITY() AS INT);";

    public readonly static string SELECT = @"select  py.Id,
                                                    py.PaymentDate,
                                                    c.CardNumber,
                                                    c.SecurityCode,
                                                    c.ExpirationDate,
                                                    c.CardHolderName,
                                                    bs.Id AS BankSlipId,
                                                    bs.Number AS BankSlipNumber,
                                                    bs.DueDate AS BankSlipDueDate,
                                                    p.Id AS PixId,
                                                    p.PixKey,
                                                    pt.Id AS PixTypeId,
                                                    pt.Name AS PixTypeName
                                            from Payment py
                                                LEFT join Card c on py.CardNumber = c.CardNumber
                                                LEFT join BankSlip bs on py.BankSlipId = bs.Id
                                                LEFT join Pix p on py.PixId = p.Id
                                                LEFT join PixType pt on p.Type = pt.Id;";

    public int Id { get; set; }
    public Card? Card { get; set; }
    public BankSlip? BankSlip { get; set; }
    public Pix? Pix { get; set; }
    public DateTime PaymentDate { get; set; }

    public Payment() { }

    public Payment(int id, Card card, BankSlip bankSlip, Pix pix, DateTime paymentDate)
    {
        Id = id;
        Card = card;
        BankSlip = bankSlip;
        Pix = pix;
        PaymentDate = paymentDate;
    }
}
