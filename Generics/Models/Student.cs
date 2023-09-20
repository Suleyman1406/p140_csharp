using System;
namespace Generics.Models;

public class Student:Person
{
	public double Grade { get; set; }

	public Student(string name) : base(name)
	{
	}
}

