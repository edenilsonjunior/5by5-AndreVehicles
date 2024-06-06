namespace Models.Sales;


public class Pix
{
    public readonly static string INSERT = "INSERT INTO Pix(Type, PixKey) VALUES(@Type, @PixKey); SELECT CAST(SCOPE_IDENTITY() AS INT);";
    public readonly static string SELECT = @"select p.Id, 
                                                    p.PixKey,
                                                    pt.Id AS PixTypeId,
                                                    pt.Name AS PixTypeName
                                             from 
                                                Pix p
                                             JOIN 
                                                PixType pt on p.Type = pt.Id;";

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

