using System;
namespace Generics.Models;

public class Person:IAlive
{
	public string Name { get; set; }

	public Person(string name)
	{
		Name = name;
	}

	public Person()
	{

	}
}

