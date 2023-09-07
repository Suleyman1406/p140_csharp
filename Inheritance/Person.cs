
public class Person:Alive
{

    public string Surname { get; set; }
    public int Age { get; set; }
    public bool Gender { get; set; }

    public Person(string name, string surname, int age):base(name)
    {
        Surname = surname;
        Age = age;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}");
    }
}

