namespace Models.People;


public class Employee : Person
{
    public readonly static string INSERT = "INSERT INTO Employee (Document, RoleId, ComissionValue, Comission) VALUES (@Document, @RoleId, @ComissionValue, @Comission);";

    public Role Role;
    public decimal CommissionValue { get; set; }
    public decimal Commission { get; set; }

    public Employee() { }

    public Employee(string document, string name, DateTime birthDate, Address address, string phone, string email, Role role, decimal commissionValue, decimal commission) : base(document, name, birthDate, address, phone, email)
    {
        Role = role;
        CommissionValue = commissionValue;
        Commission = commission;
    }

}
