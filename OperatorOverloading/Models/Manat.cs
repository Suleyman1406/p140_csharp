using System;
namespace OperatorOverloading.Models;

public class Manat
{
	public double Value { get; set; }

	public Manat(double value)
	{
		Value = value;
	}

	public static explicit operator Euro(Manat manat)
	{
		Euro euro = new Euro(manat.Value * 0.55);
		return euro;
	}


	public static double operator +(Manat m1, Manat m2)
	{
		//Manat res = new Manat(m1.Value + m2.Value);
		return m1.Value + m2.Value;
	}

	public static bool operator ==(Manat m1, Manat m2)
	{
		return m1.Value == m2.Value;
	}

    public static bool operator !=(Manat m1, Manat m2)
    {
        return m1.Value != m2.Value;
    }
	public static Manat operator -(Manat m1, Euro e1)
	{
		Manat manat = new Manat(m1.Value - e1.Value * 1.8);
		return manat;
	}
}

