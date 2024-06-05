namespace Models.Sales;


public class Card
{
    public string CardNumber { get; set; }
    public string SecurityCode { get; set; }
    public string ExpirationDate { get; set; }
    public string CardHolderName { get; set; }

    public Card() { }

    public Card(string cardNumber, string securityCode, string expirationDate, string cardHolderName)
    {
        CardNumber = cardNumber;
        SecurityCode = securityCode;
        ExpirationDate = expirationDate;
        CardHolderName = cardHolderName;
    }
}
