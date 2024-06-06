namespace Models.People;


public class Customer : Person
{
    public readonly static string INSERT = "INSERT INTO Customer (Document, Income) VALUES (@Document, @Income);";

    public decimal Income { get; set; }

    public Customer() { }

    public Customer(string document, string name, DateTime birthDate, Address address, string phone, string email, decimal income) : base(document, name, birthDate, address, phone, email)
    {
        Income = income;
    }

}
