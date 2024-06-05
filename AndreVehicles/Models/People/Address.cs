namespace Models.People;


public class Address
{
    public int Id { get; set; }
    public string Street { get; set; }
    public string PostalCode { get; set; }
    public string District { get; set; }
    public string StreetType { get; set; }
    public string AdditionalInfo { get; set; }
    public int Number { get; set; }
    public string State { get; set; }
    public string City { get; set; }

    public Address() { }

    public Address(string street, string postalCode, string district, string streetType, string additionalInfo, int number, string state, string city)
    {
        Street = street;
        PostalCode = postalCode;
        District = district;
        StreetType = streetType;
        AdditionalInfo = additionalInfo;
        Number = number;
        State = state;
        City = city;
    }
}
