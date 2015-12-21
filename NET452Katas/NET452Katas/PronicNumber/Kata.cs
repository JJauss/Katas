namespace NET452Katas.PronicNumber
{
	public class Kata
	{
		public static bool IsPronic(int n)
		{

			int x = 0, p = 0;
			bool result = false;
			while (!result && p <= n)
			{
				p = x * (x + 1);
				x++;
				result = p == n;
			}
			return result;
		}
	}
}