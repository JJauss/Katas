using System;
using System.Linq;

namespace NET452Katas.MaximumLengthDifference {
	public class MaxDiffLength
	{

		public static int Mxdiflg(string[] a1, string[] a2)
		{
			if (a1.Length < 1 || a2.Length < 1)
			{
				return -1;
			}
			return Math.Max(a1.Max(_ => _.Length) - a2.Min(_ => _.Length), a2.Max(_ => _.Length) - a1.Min(_ => _.Length));
		}
	}
}