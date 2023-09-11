
public class Motorcycle:Vehicle
{
	public bool HasABS { get; set; }

    public Motorcycle(string model, int wheelCount, string color, bool hasABS) : base(model, wheelCount, color)
    {
        HasABS = hasABS;
    }

    public override void PrintVehicleInfo()
    {
        base.PrintVehicleInfo();
        if (HasABS)
        {
            Console.WriteLine("This motorcycle has ABS.");
        }
        else
        {
            Console.WriteLine("This motorcycle hasn't ABS.");
        }
    }
}


