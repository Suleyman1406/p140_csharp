using System;
namespace Partial;

public class Hello
{
	public const int a=15;
	public readonly int b =12;

	public Hello()
	{
		b = 17;
		//a = 12;
	}

	void Test()
	{
	}
}

public partial class Trial
{

	void PrintInfo()
	{
		Console.WriteLine("Partial");
	}

}

