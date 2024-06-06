namespace Models.Cars;


public class Operation
{
    public readonly static string INSERT = "INSERT INTO Operation(Description) VALUES(@Description); SELECT CAST(SCOPE_IDENTITY() AS INT);";
    public readonly static string SELECT = "SELECT Id, Description FROM Operation";

    public int Id { get; set; }
    public string Description { get; set; }

    public Operation() { }

    public Operation(string description)
    {
        Description = description;
    }
}
