
public class Alive
{
	public string Name { get; set; }

	public Alive(string name)
	{
		Name = name;
	}

	public void MakeNoise()
	{
		Console.WriteLine(Name + " made noise");
	}
}


