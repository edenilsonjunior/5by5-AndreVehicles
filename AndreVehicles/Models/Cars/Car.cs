namespace Models.Cars;


public class Car
{
    public readonly static string INSERT = "INSERT INTO Car(Plate, Name, YearManufacture, YearModel, Color, Sold) VALUES(@Plate, @Name, @YearManufacture, @YearModel, @Color, @Sold)";

    public readonly static string SELECT = "SELECT Plate, Name, YearManufacture, YearModel, Color, Sold FROM Car";

    public string Plate { get; set; }
    public string Name { get; set; }
    public int YearManufacture { get; set; }
    public int YearModel { get; set; }
    public string Color { get; set; }
    public bool Sold { get; set; }

    public Car() { }

    public Car(string plate, string name, int yearManufacture, int yearModel, string color, bool sold)
    {
        Plate = plate;
        Name = name;
        YearManufacture = yearManufacture;
        YearModel = yearModel;
        Color = color;
        Sold = sold;
    }

    public override string ToString()
    {
        string str = "";
        str += $"Placa.............: {Plate}\n";
        str += $"Nome..............: {Name}\n";
        str += $"Ano de fabricação.: {YearManufacture}\n";
        str += $"Ano do modelo.....: {YearModel}\n";
        str += $"Cor...............: {Color}\n";
        str += $"Vendido...........: {(Sold ? "Sim" : "Não")}";
        return str;
    }
}
