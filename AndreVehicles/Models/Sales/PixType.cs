namespace Models.Sales;


public class PixType
{
    public int Id { get; set; }
    public string Name { get; set; }

    public PixType() { }

    public PixType(string name)
    {
        Name = name;
    }
}
