﻿namespace Models.Sales;


public class Payment
{
    public readonly static string INSERT = "INSERT INTO Payment(CardNumber, BankSlipId, PixId, PaymentDate) VALUES(@CardNumber, @BankSlipId, @PixId, @PaymentDate); SELECT CAST(SCOPE_IDENTITY() AS INT);";

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
