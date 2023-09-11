
public class ElectricCar:Car
{
    public double BatteryLife { get; set; }

    public ElectricCar(string model, int wheelCount, string color, int doorCount, double batteryLife) : base(model, wheelCount, color, doorCount)
    {
        BatteryLife = batteryLife;
    }

    public override void PrintVehicleInfo()
    {
        base.PrintVehicleInfo();
        Console.WriteLine($"This car's battery life is {BatteryLife}%.");
    }
}


