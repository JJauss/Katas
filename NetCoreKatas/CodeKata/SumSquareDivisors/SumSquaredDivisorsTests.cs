using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKata.SumSquareDivisors
{
  [TestClass]
  public class SumSquaredDivisorsTests
  {
    [TestMethod]
    public void Test01()
    {
      Assert.AreEqual("[[1, 1], [42, 2500], [246, 84100]]", Kata.listSquared(1, 250));
    }
    [TestMethod]
    public void Test02()
    {
      Assert.AreEqual("[[42, 2500], [246, 84100]]", Kata.listSquared(42, 250));
    }
    [TestMethod]
    public void Test03()
    {
      Assert.AreEqual("[[287, 84100]]", Kata.listSquared(250, 500));
    }

  }

  public class Kata
  {

    public static string listSquared(long m, long n)
    {
     List<string> result = new List<string>();
      // your code
      for (long start = m; start < n; start++) {
        IEnumerable<long> divisorList = GetDivisors(start);
        long sum = divisorList.Select(d => d * d).Sum();
        bool match = Math.Sqrt(sum) % 1 == 0;

        if (match) {
          result.Add($"[{start}, {sum}]");
        }
      }
      return $"[{string.Join(", ", result)}]";
    }

    private static IEnumerable<long> GetDivisors(long number) {
      for (long divisor = 1; divisor < number +1; divisor++) {
        if (number % divisor == 0)
        {
          yield return divisor;
        }
      }
    }
  }
}
