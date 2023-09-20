using System;
namespace OperatorOverloading.Models
{
	public class Euro
	{
		public double Value { get; set; }

        public Euro(double value)
		{
			Value = value;
		}

		public static explicit operator Manat(Euro euro)
		{
			Manat manat2 = new Manat(euro.Value*1.8);
			return manat2;
		}

	}
}

