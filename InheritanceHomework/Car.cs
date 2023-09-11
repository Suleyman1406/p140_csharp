
public class Car:Vehicle
{
    public int DoorCount { get; set; }

    public Car(string model, int wheelCount, string color, int doorCount) : base(model, wheelCount, color)
    {
        DoorCount = doorCount;
    }


    public override void PrintVehicleInfo()
    {
        base.PrintVehicleInfo();
        Console.WriteLine($"This car has {DoorCount} door(s).");
    }
}

