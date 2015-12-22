using System;
using System.Linq;

namespace NET452Katas.ExcelToNumber
{
	public class ExcelToNumber
	{
		public static long TitleToNumber(string title) {
			string titleReverse = new string(title.Reverse().ToArray()); 
			long sum = 0;
			for (int index = 0; index < titleReverse.Length; index++) {
				int number = titleReverse[index] - 64;
				sum += number * (long)Math.Pow(26 , index);
			}
			return sum;
		}
	}
}