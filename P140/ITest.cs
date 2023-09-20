using System;
namespace P140
{
	public interface ITest
	{
		public string Name { get; set; }

		public void Hello()
		{
			Console.WriteLine("Hello");
		}


	}
}

