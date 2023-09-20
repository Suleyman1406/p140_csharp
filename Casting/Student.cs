
public class Student:Person
{
    public double Grade { get; set; }


    public Student(string name, string surname, int age, double grade) : base(name, surname, age)
    {
        Grade = grade;
    }

}
