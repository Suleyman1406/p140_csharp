
public class Person
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public int Age { get; set; }

    public Person()
	{

        Console.WriteLine("Bos constructor");
	}

    public Person(string name, string surname, int age) 
    {
        Name = name;
        Surname = surname;
        Age = age;
        Console.WriteLine("Full constructor");

    }

    //public Person(string name, string surname)
    //{
    //    Name = name;
    //    Surname = surname;
    //}


}

