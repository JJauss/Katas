using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NET452Katas.MaximumLengthDifference
{
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
