namespace Models.Cars;


public class Purchase
{
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
