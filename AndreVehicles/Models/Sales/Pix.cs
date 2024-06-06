namespace Models.Sales;


public class Pix
{
    public int Id { get; set; }
    public PixType Type { get; set; }
    public string PixKey { get; set; }

    public Pix() { }

    public Pix(PixType type, string pixKey)
    {
        Type = type;
        PixKey = pixKey;
    }
}
