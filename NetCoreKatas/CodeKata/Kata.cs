using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public static class Kata
{

  public static string PigIt(string str)
  {
    string[] words = str.Split(" ");
    bool isWord(string word) => new Regex(@"^\w*$").IsMatch(word);
    StringBuilder sb = new StringBuilder();
    foreach (string word in words)
    {
      if (sb.Length > 0) sb.Append(" ");
      if (!isWord(word))
      {
        sb.Append(word);
      }
      else
      {
        sb.Append($"{word.Substring(1)}{word[0]}ay");
      }


    }
    return sb.ToString();
  }

  public static string High(string s)
  {

    string[] words = s.Split(" ");
    int lastWeight = 0;
    string lastWord = "";
    foreach (string word in words)
    {
      int currentWeight = word.Sum(c => c - 'a');

      if (lastWeight < currentWeight)
      {
        lastWord = word;
        lastWeight = currentWeight;
      }
    }

    return lastWord;
  }


  public static bool IsValidWalk(string[] walk)
  {
    //insert brilliant code here
    if (walk.Length != 10) return false;
    Dictionary<string, int> durationsNorthSouth = new Dictionary<string, int>() { { "n", 1 }, { "s", -1 }, { "w", 0 }, { "e", 0 } };
    Dictionary<string, int> durationsEastWest = new Dictionary<string, int>() { { "n", 0 }, { "s", 0 }, { "w", 1 }, { "e", -1 } };
    int sum1 = 0;
    int sum2 = 0;
    foreach (string direction in walk)
    {
      sum1 += durationsNorthSouth[direction];
      sum2 += durationsEastWest[direction];
    }

    return sum1 == 0 && sum2 == 0;

  }

  public static bool Narcissistic(int value)
  {
    // Code me
    char[] numbers = value.ToString().ToCharArray();
    int pow = numbers.Length;
    int sum = 0;
    foreach (char numChar in numbers)
    {
      sum += (int)Math.Pow(Int32.Parse(numChar.ToString()), pow);
    }
    return sum == value;
  }

  public static int FindEvenIndex(int[] arr)
  {
    int sumLeft = 0, sumRight = 0;

    //Code goes here!
    for (int index = 0; index < arr.Length; index++)
    {
      sumLeft = SummarizeArrayRange(arr, 0, index);
      sumRight = SummarizeArrayRange(arr, index + 1, arr.Length);

      if (sumLeft == sumRight)
      {
        return index;
      }
    }

    return -1;
  }

  private static int SummarizeArrayRange(int[] arr, int start, int end)
  {
    int sum = 0;

    for (var i = start; i < end; i++)
    {
      sum += arr[i];
    }

    return sum;
  }

  public static string GetReadableTime(int seconds)
  {
    int sec = seconds % 60;
    int min = ((seconds - sec) % 3600) / 60;
    int hours = seconds / 3600;

    return $"{hours:D2}:{min:D2}:{sec:D2}";

  }

  public static ICollection GetPINs(string pinKey)
  {
    char[,] numPad = new char[,] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' }, { Char.MinValue, '0', Char.MinValue } };
    List<string> result = new List<string>();
    List<char> pins = new List<char>();
    for (int index = 0; index < pinKey.Length; index++)
    {
      char digit = pinKey[index];
      char[] currentPin = pinKey.ToCharArray();

      if (numPad.GetPosition(digit, out int row, out int col))
      {
        foreach (char inputKey in numPad.GetNumPadInputAndNeighbours(row, col))
        {
          pins.Add(inputKey);
          //currentPin[index] = inputKey;
          //result.Add(string.Join("", currentPin));
          //result.Add(new string(inputKey, pinKey.Length));
        }
      }
    }

    for (int index = 0; index < pins.Count; index++) {
      char[] buffer = new char[pinKey.Length - 1];
      for (int i = 0; i < buffer.Length; i++) {
        foreach (char pin in pins) {
          buffer[i] = pin;
        }
      }
      result.Add(string.Join("", buffer));
    }

    return result.Distinct().ToList();
  }

  public static bool GetPosition(this char[,] numPad, char digit, out int row, out int col)
  {
    col = -1;
    for (row = 0; row < numPad.GetLength(0); row++)
    {
      for (col = 0; col < numPad.GetLength(1); col++)
      {
        if (digit == numPad[row, col])
        {
          return true;
        }
      }
    }

    return false;
  }

  public static IEnumerable<char> GetNumPadInputAndNeighbours(this char[,] numPad, int row, int col)
  {
    char c = Char.MinValue;
    
    c = numPad[row, col];

    if (row > 0)
    {
      yield return numPad[row - 1, col];
    }
    if (row < numPad.GetLength(0))
    {
      yield return numPad[row + 1, col];
    }

    if (col > 0)
    {
      yield return numPad[row, col - 1];
    }
    if (col < numPad.GetLength(1))
    {
      yield return numPad[row, col + 1];
    }

    yield return c;
  }
}