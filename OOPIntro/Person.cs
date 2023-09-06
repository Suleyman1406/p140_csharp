
public class Person
{
	private double weight =12;
    private string name = "asd";
    private byte age = 12;

	public string Job { get; private set; }

	public Person(double weight, string name, byte age, string job)
	{
		this.weight = weight;
		this.name = name;
		this.age = age;
		this.Job = job;
	}
	
	public Person(double weight, string name, byte age)
	{
        this.weight = weight;
        this.name = name;
        this.age = age;
    }

	public Person()
	{

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

