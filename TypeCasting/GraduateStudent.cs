
public class GraduateStudent:Person
{
	public string ProjectIdea { get; set; }

	public GraduateStudent(string projectIdea, double grade, string name): base(grade, name)
	{
		ProjectIdea = projectIdea;
	}

    public static explicit operator Teacher(GraduateStudent graduateStudent)
    {
        Teacher teacher = new Teacher(0, graduateStudent.Name);
        return teacher;
    }

    //public static implicit operator Teacher(GraduateStudent graduateStudent)
    //{
    //    Teacher teacher = new Teacher(0, graduateStudent.Name);
    //    return teacher;
    //}
}

