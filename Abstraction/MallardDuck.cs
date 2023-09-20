
public class MallardDuck:Duck,IFlyable, IQuackable
{
	public MallardDuck()
	{
	}

    public void Fly()
    {
        Console.WriteLine("Mallard Duck is flying");
    }


    public override void Display()
    {
        Console.WriteLine("This is the Green Head Duck.");
    }

    public void Quack()
    {
        Console.WriteLine("Green Quack");
    }

    public override void Swim()
    {
        Console.WriteLine("Green Head Duck is swimming");
    }
}


