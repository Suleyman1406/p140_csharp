public class FuelCar: Car
{
    public double EngineVolume { get; set; }

    public FuelCar(string model, int wheelCount, string color, int doorCount, double engineVolume) : base(model, wheelCount, color, doorCount)
    {
        EngineVolume = engineVolume;
    }

    public override void PrintVehicleInfo()
    {
        base.PrintVehicleInfo();
        Console.WriteLine($"This car's engine volume is {EngineVolume}");
    }
}

