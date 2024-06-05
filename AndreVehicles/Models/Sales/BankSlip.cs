namespace Models.Sales;


public class BankSlip
{
    public int Id { get; set; }
    public int Number { get; set; }
    public DateTime DueDate { get; set; }

    public BankSlip() { }

    public BankSlip(int id, int number, DateTime dueDate)
    {
        Id = id;
        Number = number;
        DueDate = dueDate;
    }
}
