public class Student:Person
{
	public double Grade { get; set; }

	public Student(double grade, string name):base(name)
	{
		Grade = grade;
	}

	public static explicit operator GraduateStudent(Student student)
	{
		GraduateStudent graduate = new GraduateStudent(null, student.Grade, student.Name);
		return graduate;
	}
}

