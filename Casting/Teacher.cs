public class Teacher : Person
{
    public int Experience { get; set; }

    public Teacher(string name, string surname, int age, int experience) : base(name, surname, age)
    {
        Experience = experience;
    }
}

