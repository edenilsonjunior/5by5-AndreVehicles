namespace Models.Sales;


public class Pix
{
    public readonly static string INSERT = "INSERT INTO Pix(Type, PixKey) VALUES(@Type, @PixKey); SELECT CAST(SCOPE_IDENTITY() AS INT);";

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

