using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NET452Katas.SumOfOddNumbers {
	[TestClass]
	public class Test
	{
		[TestMethod]
		public void test1()
		{
			Assert.AreEqual(1, Kata.rowSumOddNumbers(1));
			Assert.AreEqual(8, Kata.rowSumOddNumbers(2));
			Assert.AreEqual(74088, Kata.rowSumOddNumbers(42));
		}

	}
}