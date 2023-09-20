using System;

public class Vehicle
{
    public Vehicle()
    {
        Console.WriteLine("base constructor");
    }

    public Vehicle(string name)
    {
        Console.WriteLine($"{name} base constructor");
    }

}

