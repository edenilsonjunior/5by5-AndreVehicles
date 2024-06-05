namespace Models.People;


public class Employee : Person
{
    public Role Role;
    public decimal CommissionValue { get; set; }
    public decimal Commission { get; set; }

    public Employee() { }

    public Employee(string document, string name, DateTime birthDate, Address address, string phone, string email, Role role, Decimal commissionValue, Decimal commission)
    {
        Document = document;
        Name = name;
        BirthDate = birthDate;
        Address = address;
        Phone = phone;
        Email = email;
        Role = role;
        CommissionValue = commissionValue;
        Commission = commission;
    }

}
