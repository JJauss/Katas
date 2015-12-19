using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NET452Katas
{


		public class MaxDiffLength
		{

			public static int Mxdiflg(string[] a1, string[] a2) {
				if (a1.Length < 1 || a2.Length < 1) {
					return -1;
				}
			return Math.Max(a1.Max(_ => _.Length) - a2.Min(_ => _.Length), a2.Max(_ => _.Length) - a1.Min(_ => _.Length));
			}
		}
	

	[TestClass]
	public class MaximumLengthDifferenceTest
	{

		[TestMethod]
		public static void test1()
		{
			string[] s1 = new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
			string[] s2 = new string[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
			Assert.AreEqual(13, MaxDiffLength.Mxdiflg(s1, s2));
		}

		[TestMethod]
		public static void test2()
		{
			string[] s1 = new string[] { };
			string[] s2 = new string[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
			Assert.AreEqual(-1, MaxDiffLength.Mxdiflg(s1, s2));
		}
	}

}
