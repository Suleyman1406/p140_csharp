public class Teacher:Person
{
    public double Experience { get; set; }


    public IstenilenSoz(string name, string surname, int age, double experience ): base(name, surname, age)
    {
        Experience = experience;
    }

    public void MakeExam()
    {
        Console.WriteLine(Name + " made exam");
    }

    public  void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Experience: {Experience}");
    }


}

