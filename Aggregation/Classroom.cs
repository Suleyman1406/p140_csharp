
public class Classroom
{
	public string Name { get; set; }
	private Student[] students;

    public Classroom(string name)
	{
		Name = name;
        students = new Student[0];
	}

	public void PrintStudentsInfo()
	{
		if(students.Length ==0)
		{
			Console.WriteLine("There is no student in classroom.");
			return;
		}
		foreach(Student student in students)
		{
			student.PrintInfo();
		}
	}

	public void PrintStudentCount()
	{
		Console.WriteLine($"Student count is {students.Length}");
	}

	public void AddStudent(Student student)
	{
		Array.Resize(ref students, students.Length + 1);
		students[students.Length-1] = student;
	}
}


