using System;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler
{
	/// <summary>
	/// Multiples of 3 and 5
	/// </summary>
	/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
	/// Find the sum of all the multiples of 3 or 5 below 1000.

	public static class Problem001
	{
		public static void Solution()
		{
			long sum = 0;
			long limit = 1000;
			// sum of arithmetic progression
			// n * (a_1 + a_n) / 2
			sum += ((long)limit - 1) / 3 * (3 + 999) / 2;
			sum += ((long)limit - 1) / 5 * (5 + 995) / 2;
			sum -= ((long)limit - 1) / 15 * (15 + 990) / 2;
			
			Debug.WriteLine(sum);
		}
	}
}
