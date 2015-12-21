using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NET452Katas.PronicNumber {
	[TestClass]
	public class PronicNumberTests
	{
		[TestMethod]
		public void FixedTest()
		{
			Assert.AreEqual(true, Kata.IsPronic(0));
			Assert.AreEqual(false, Kata.IsPronic(1));
			Assert.AreEqual(true, Kata.IsPronic(2));
			Assert.AreEqual(false, Kata.IsPronic(3));
			Assert.AreEqual(false, Kata.IsPronic(4));
			Assert.AreEqual(false, Kata.IsPronic(5));
			Assert.AreEqual(true, Kata.IsPronic(6));
			Assert.AreEqual(false, Kata.IsPronic(-3));
			Assert.AreEqual(false, Kata.IsPronic(-27));
			Assert.AreEqual(true, Kata.IsPronic(100 * (100+1)));
		}
	}
}