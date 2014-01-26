using System;
using System.Diagnostics;
using System.Numerics;

namespace ProjectEuler
{

	public static class Problem401
	{
		public static void Solution()
		{
			// 400686363385965077
			// 1000000
			// 385965077
			// 400685641565621401132515
			// 166146701
			BigInteger n = 50;//(BigInteger) Math.Pow(10,6);
			BigInteger m = (BigInteger) Math.Pow(10,1);
			BigInteger sum = 0;
			
			BigInteger x = 0;
			BigInteger y = 0;
			BigInteger sumOfSeries = 0;
			
			BigInteger sqrtn = (BigInteger) Math.Floor(Math.Sqrt((double) n));
			
			for (BigInteger i = 1; i <= (BigInteger) Math.Floor(Math.Sqrt((double) n)) ; i++) {
				BigInteger c = n / i;
				sum += c * i * i;
				x = n / i;
				y = n / (i + 1);
				sumOfSeries = s(x, m) - s(y, m);
				if (i == sqrtn)
					Debug.WriteLine(sumOfSeries + " " + sqrtn * sqrtn);
				sum += sumOfSeries * i;
			}
			sum -= (sumOfSeries * (n / x));
			//sum += sqrtn * sqrtn * sqrtn;
			Debug.WriteLine(sum);
		}
		
		public static BigInteger s(BigInteger n, BigInteger m)
		{
			BigInteger a = n;
			BigInteger b = n + 1;
			BigInteger c = 2 * a + 1;
			BigInteger d = ((a % m) * (b % m));
			BigInteger e = ((d % m) * (c % m));
			return (a * b * c) / 6;
		}
	}
}
