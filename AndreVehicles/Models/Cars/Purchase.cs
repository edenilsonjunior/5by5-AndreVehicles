﻿namespace Models.Cars;


public class Purchase
{
    public readonly static string INSERT = "INSERT INTO Purchase (CarPlate, Price, PurchaseDate) VALUES(@CarPlate, @Price, @PurchaseDate)";
    public readonly static string SELECT = @"select c.Plate,
        c.Name, 
        c.YearManufacture, 
        c.YearModel, 
        c.Color, 
        c.Sold,
        p.Id AS PurchaseId,
        p.Price AS PurchacePrice,
        p.PurchaseDate
        FROM Car c
        JOIN Purchase p ON c.Plate = p.CarPlate;";

    public int Id { get; set; }
    public Car Car { get; set; }
    public decimal Price { get; set; }
    public DateTime PurchaseDate { get; set; }

    public Purchase() { }

    public Purchase(Car car, decimal price, DateTime purchaseDate)
    {
        Car = car;
        Price = price;
        PurchaseDate = purchaseDate;
    }
}
