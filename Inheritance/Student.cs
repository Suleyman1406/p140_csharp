
public class Student: Person
{

	public double Grade { get; set; }

    public Student(string name, string surname, int age, double grade): base(name, surname, age)
    {
        Grade = grade;
    }

	public void DoHomework()
	{
		Console.WriteLine(Name + " did homework.");
	}

	public  void PrintInfo()
	{
		Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Grade: {Grade}");
	}
}


