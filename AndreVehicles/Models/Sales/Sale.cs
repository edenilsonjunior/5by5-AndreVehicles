namespace Models.Sales;

using Models.Cars;
using Models.People;

public class Sale
{
    public readonly static string INSERT = "INSERT INTO Sale(CustomerDocument, EmployeeDocument, CarPlate, PaymentId, SaleDate, SalePrice) VALUES(@CustomerDocument, @EmployeeDocument, @CarPlate, @PaymentId, @SaleDate, @SalePrice);";
    public readonly static string SELECT = @"select Id, CustomerDocument, EmployeeDocument, CarPlate, PaymentId, SaleDate, SalePrice from Sale";

    public int Id { get; set; }
    public Customer Customer { get; set; }
    public Employee Employee { get; set; }
    public Car Car { get; set; }
    public Payment Payment { get; set; }
    public DateTime SaleDate { get; set; }
    public decimal SalePrice { get; set; }

    public Sale() { }

    public Sale(int id, Customer customer, Employee employee, Car car, Payment payment, DateTime saleDate, decimal salePrice)
    {
        Id = id;
        Customer = customer;
        Employee = employee;
        Car = car;
        Payment = payment;
        SaleDate = saleDate;
        SalePrice = salePrice;
    }
}
