using System;

namespace NET452Katas.PronicNumber
{
	public class Kata
	{
		public static bool IsPronic(int n)
		{
			int value = (int)Math.Sqrt(n);
			return (value * (value + 1)) == n;
		}
	}
}