using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace ProjectEuler
{
	public static class Problem455
	{
		public static void Solution()
		{
			BigInteger mLimit = (BigInteger) Math.Pow(10,9);
			BigInteger limit = (BigInteger) Math.Pow(10,6);
			BigInteger sum = 0;

			for (BigInteger n = 2; n <= limit; n++)
			{
				BigInteger k = 0;
				BigInteger m = 100;
				for (BigInteger i = 0; i < 100; i++)
				{
					if (BigInteger.ModPow(n, i, m) == i)
					{
						k = i;
						while (m <= mLimit)
						{
							k = BigInteger.ModPow(n, k, m);
							m *= 10;
						}
						break;
					}
				}
				sum += k;
			}
			Debug.WriteLine(sum);
		}
		
		public static void NaiveSolution()
		{
			BigInteger m = 10000;
			BigInteger limit = 100;
			BigInteger sum = 0;
			
			for (BigInteger n = 2; n <= limit; n++)
			{
				for (BigInteger k = m; k >= 0; k--)
					if (BigInteger.ModPow(n, k, m) == k)
						sum += k;
			}
			
			Debug.WriteLine(sum);
		}
	}
}
