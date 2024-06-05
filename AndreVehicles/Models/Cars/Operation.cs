namespace Models.Cars;


public class Operation
{
    public int Id { get; set; }
    public string Description { get; set; }

    public Operation() { }

    public Operation(string description)
    {
        Description = description;
    }
}
