﻿namespace Models.People;


public class Customer : Person
{
    public readonly static string INSERT = "INSERT INTO Customer (Document, Income) VALUES (@Document, @Income);";
    public readonly static string SELECT = @"SELECT 
                                                p.Document,
                                                p.Name,
                                                p.BirthDate,
                                                p.Phone,
                                                p.Email,
                                                a.Street,
                                                a.PostalCode,
                                                a.District,
                                                a.StreetType,
                                                a.AdditionalInfo,
                                                a.Number,
                                                a.State,
                                                a.City,
                                                c.Income
                                            FROM 
                                                Person p
                                            JOIN 
                                                Address a ON p.AddressId = a.Id
                                            JOIN 
                                                Customer c ON p.Document = c.Document;";

    public decimal Income { get; set; }

    public Customer() { }

    public Customer(string document, string name, DateTime birthDate, Address address, string phone, string email, decimal income) : base(document, name, birthDate, address, phone, email)
    {
        Income = income;
    }

}
