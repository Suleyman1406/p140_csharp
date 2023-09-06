public class Operations
{
	public int number1;
	public int number2;

	public Operations(int number1, int number2)
    {
		this.number1 = number1;
		this.number2 = number2;
		Console.WriteLine( Sum());
	}

	private int Sum()
	{
		return number1 + number2;
	}

	public int Multiply()
	{
		return number1 * number2;
	}
}

