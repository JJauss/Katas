using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKata.FindUniqueNumber
{
  [TestClass]
  public class FindUniqueNumberTests
  {

    [TestMethod]
    [DataRow(new[] { 1, 2, 2, 2 }, 1)]
    [DataRow(new[] { -2, 2, 2, 2 }, -2)]
    [DataRow(new[] { 11, 11, 14, 11, 11 }, 14)]
    public void BaseTest(IEnumerable<int> numbers, int expected)
    {
      Assert.AreEqual(expected, Kata.GetUnique(numbers));
    }
  }

  public class Kata {

    public static int GetUnique(IEnumerable<int> numbers) {
      return numbers.GroupBy(n => n)
                    .Single(r => r.Count() == 1).Key;
    }
  }
}
