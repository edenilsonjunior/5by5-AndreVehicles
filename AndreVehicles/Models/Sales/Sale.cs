namespace Models.Sales;

using Models.Cars;
using Models.People;

public class Sale
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public Employee Employee { get; set; }
    public Car Car { get; set; }
    public Payment Payment { get; set; }
    public DateTime SaleDate { get; set; }
    public decimal SalePrice { get; set; }
}
