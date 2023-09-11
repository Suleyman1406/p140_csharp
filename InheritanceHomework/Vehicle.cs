public class Vehicle
{
	public static int VehicleCount { get; set; } = 0;
	public string Model { get; set; }
	public string Color { get; set; }
    public int WheelCount { get; set; }

    public Vehicle(string model, int wheelCount, string color)
    {
        WheelCount = wheelCount;
        Model = model;
        Color = color;
        VehicleCount++;
    }

    public static void PrintVehicleCount()
    {
        Console.WriteLine($"\nTotal Vehicle count is {VehicleCount}.");
    }

    public virtual void PrintVehicleInfo()
    {
        Console.WriteLine($"\nModel: {Model}, WheelCount: {WheelCount}, Color: {Color}");
    }
}


