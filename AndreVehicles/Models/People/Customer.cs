namespace Models.People;


internal class Customer : Person
{
    public decimal Income { get; set; }
    public string Document { get; set; }

    public Customer() { }

    public Customer(string document, string name, DateTime birthDate, Address address, string phone, string email, decimal income)
    {
        Document = document;
        Name = name;
        BirthDate = birthDate;
        Address = address;
        Phone = phone;
        Email = email;
        Income = income;
    }
}
