using System;
namespace Extension;

public static class IntExtensions
{
	public static bool IsPrime(this int value)
	{
		for(int i = 2; i < value; i++)
		{
			if (value % i == 0)
			{
				return false;
			}
		}
		return true;
	}
}

