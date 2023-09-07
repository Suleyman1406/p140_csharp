
public class Person
{
	private double weight =12;
    private string name = "asd";
    private byte age = 12;
	
    public string Job { get; private set; }

	public Person(string name, string job)
	{
		this.name = name;
		Job = job;
		Console.WriteLine(Job);
	}

	public double GetWeight()
	{
		return weight;
	}

	public void SetWeight(double weight)
	{
		this.weight = weight;
	}

}

