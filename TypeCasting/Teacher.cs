public class Teacher:Person
{
	public int Experience { get; set; }


	public Teacher(int experience, string name):base(name)
	{
		Experience = experience;
	}
}

