using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKata
{
  [TestClass]
  public class KataTests
  {
    [TestMethod]
    public void GenericTests()
    {
      Assert.AreEqual(3, Kata.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
      Assert.AreEqual(1, Kata.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
      Assert.AreEqual(-1, Kata.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
      Assert.AreEqual(3, Kata.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
    }

    [TestMethod]
    public void HumanReadableTest()
    {
      StringAssert.StartsWith(Kata.GetReadableTime(0), "00:");
      Assert.AreEqual("00:00:00", Kata.GetReadableTime(0));
      Assert.AreEqual("00:00:05", Kata.GetReadableTime(5));
      Assert.AreEqual("00:01:00", Kata.GetReadableTime(60));
      Assert.AreEqual("23:59:59", Kata.GetReadableTime(86399));
      Assert.AreEqual("99:59:59", Kata.GetReadableTime(359999));
    }

    [TestMethod]
    [DataRow(1, true)]
    [DataRow(371, true)]
    [DataRow(154, false)]
    public void TestNarcissistic(int n, bool expected)
    {
      Assert.AreEqual(expected, Kata.Narcissistic(n));

    }

    [TestMethod]
    public void TakeATenMinuteWalkTes()
    {
      Assert.AreEqual(true, Kata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
      Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
      Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "w" }), "should return false");
      Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
    }

    [TestMethod]
    [DataRow("man i need a taxi up to ubud", "taxi")]
    [DataRow("what time are we climbing up to the volcano", "volcano")]
    [DataRow("take me to semynak", "semynak")]
    public void HighestScoringWordTest(string s, string expected) => Assert.AreEqual(expected, Kata.High(s));


    [TestMethod]
    public void SimplePigLatinTest()
    {
      Assert.AreEqual("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
      Assert.AreEqual("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
      Assert.AreEqual("hisTay siay ymay tringsay !", Kata.PigIt("This is my string !"));
    }


    [TestMethod]
    public void TheObservedPINTests() {
      var expectations = new Dictionary<string, string[]>{
                                                           { "8", new[] { "5", "7", "8", "9", "0" } },
                                                           {"11",  new[]{"11", "22", "44", "12", "21", "14", "41", "24", "42" } },
                                                           {"369", new[] { "339","366","399","658","636","258","268","669","668","266","369","398","256","296","259","368","638","396","238","356","659","639","666","359","336","299","338","696","269","358","656","698","699","298","236","239" } }
                                                         };

      foreach (var pin in expectations)
      {
        CollectionAssert.AreEquivalent(pin.Value, Kata.GetPINs(pin.Key), "PIN: " + pin);
      }
    }
  }
}