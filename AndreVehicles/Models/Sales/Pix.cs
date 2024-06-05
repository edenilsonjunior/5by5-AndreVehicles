namespace Models.Sales;


public class Pix
{
    public int Id { get; set; }
    public PixType Type { get; set; }
    public string Key { get; set; }

    public Pix() { }

    public Pix(PixType type, string key)
    {
        Type = type;
        Key = key;
    }
}
