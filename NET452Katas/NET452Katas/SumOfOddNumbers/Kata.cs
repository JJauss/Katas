namespace NET452Katas.SumOfOddNumbers
{
	public static class Kata
	{
		public static long rowSumOddNumbers(long n)
		{
			long currentNumber = 1, sum = 0;
			for(long currentRow = 0; currentRow < n; currentRow++)
			{
				sum = 0;
				for (long pos = 0; pos < (currentRow +1); currentNumber += 2, pos++)
				{
					sum += currentNumber;
				}
			}
			return sum;
		}
	}
}