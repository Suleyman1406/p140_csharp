public class RubberDuck:Duck,IQuackable
{
	public RubberDuck()
	{
	}

    public override void Display()
    {
        Console.WriteLine("Yello Rubber Duck");
    }

   

    public void Quack()
    {
        Console.WriteLine("Rubber Quack");
    }

    public override void Swim()
    {
        Console.WriteLine("Rubber Duck is swimming");
    }
}

