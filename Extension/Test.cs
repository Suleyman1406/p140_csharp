using System;
namespace Extension
{
	public static class Test
	{
		public static string RemoveFirst(this string val)
		{
			return val.Substring(1);
		}

		public static void WriteLine(this ConsoleColor consoleColor, string text)
		{
			Console.ForegroundColor = consoleColor;
			Console.WriteLine(text);
			Console.ResetColor();
		}
	}
}

