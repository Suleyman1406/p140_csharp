
public class ReadHeadDuck:Duck,IQuackable,IFlyable
{
	public ReadHeadDuck()
	{
	}

    public void Fly()
    {
        Console.WriteLine("Red Head Duck is flying");
    }


    public override void Display()
    {
        Console.WriteLine("This is the Red Head Duck.");
    }

    //public override void Fly()
    //{
    //    Console.WriteLine("Read Head Duck flying");
    //}

    public void Quack()
    {
        Console.WriteLine("Red Quack");
    }

    public override void Swim()
    {
        Console.WriteLine("Red Head Duck is swimming");
    }
}


