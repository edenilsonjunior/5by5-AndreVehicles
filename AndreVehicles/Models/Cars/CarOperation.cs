namespace Models.Cars;


public class CarOperation
{
    public int Id { get; set; }
    public Car Car { get; set; }
    public Operation Operation { get; set; }

    public CarOperation() { }

    public CarOperation(Car car, Operation operation)
    {
        Car = car;
        Operation = operation;
    }
}
