using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKata.AddingBigNumbers
{
  [TestClass]
  public class AddingBigNumbersTests
  {
    [TestMethod]
    public void MyTest()
    {
      Assert.AreEqual("3", Kata.add("1", "2"));
      Assert.AreEqual("444", Kata.add("123", "321"));
      Assert.AreEqual("110", Kata.add("11", "99"));
      Assert.AreEqual((long.MaxValue + 1d).ToString("0"), Kata.add(long.MaxValue.ToString(), "1"));
    }

  }

  public class Kata {
    public static string add(string a, string b) {
      return $"{(double.Parse(a) + double.Parse(b)):0}";
    }
  }
}
