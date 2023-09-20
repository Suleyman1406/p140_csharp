using System;
namespace Generics.List;

public class StringList
{
	private string[] items;
	public string[] Items { get => items; set => items = value; }


	public StringList(params string[] items )
	{
        this.items = items;
	}

	public void Add(string item)
	{
		Array.Resize(ref items, items.Length + 1);
        items[items.Length - 1] = item;
	}

	public string? GetAtIndex(int idx)
	{
		if(idx<0 || idx >= items.Length)
		{
			Console.WriteLine("Bu Index istifade edile bilmir.");
			return null;
		}
		return items[idx];
	}

	public void Print()
	{
		foreach(string item in items)
		{
			Console.WriteLine(item);
		}
	}


}

