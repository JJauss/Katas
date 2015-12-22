using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NET452Katas.ExcelToNumber {
	[TestClass]
	public class ExcelToNumberTests
	{

		[TestMethod]
		public void Test1()
		{
			Console.WriteLine("****** Basic Tests");
			Assert.AreEqual(1, ExcelToNumber.TitleToNumber("A"));
			Assert.AreEqual(27, ExcelToNumber.TitleToNumber("AA"));
			Assert.AreEqual(52, ExcelToNumber.TitleToNumber("AZ"));
			Assert.AreEqual(53, ExcelToNumber.TitleToNumber("BA"));
			Assert.AreEqual(28779382963L, ExcelToNumber.TitleToNumber("CODEWARS"));
		}
	}
}