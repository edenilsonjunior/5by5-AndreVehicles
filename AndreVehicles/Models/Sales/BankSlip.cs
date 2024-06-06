namespace Models.Sales;


public class BankSlip
{
    public readonly static string INSERT = "INSERT INTO BankSlip(Number, DueDate) VALUES(@Number, @DueDate); SELECT CAST (SCOPE_IDENTITY() AS INT);";

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
