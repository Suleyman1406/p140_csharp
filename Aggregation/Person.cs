﻿public class Person
{
	public string Name { get; set; }
	public Address Address { get; set; }
		 
	public Person(string name, Address address)
	{
		Name = name;
		Address = address;
	}

	public void PrintAddressInfo()
	{
		Console.WriteLine($"{Address.Country} {Address.City} {Address.Street}");
	}
}

