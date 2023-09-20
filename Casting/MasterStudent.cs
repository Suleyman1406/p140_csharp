
public class MasterStudent:Student
{
    public string Project { get; set; }

    public MasterStudent(string name, string surname, int age, double grade, string project) : base(name, surname, age, grade)
    {
        Project = project;
    }

}


