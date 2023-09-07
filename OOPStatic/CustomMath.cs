
public static class CustomMath
{
	//public static int b;
	//public int a;

	static CustomMath()
	{
		Console.WriteLine("Static constructor isledi");
	}


	//public int Min(int a, int b)
	//{
	//	if (a > b)
	//	{
	//		return b;
	//	}
	//	return a;
	//}

	public static int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        return b;
    }


}