using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			// 255045053
			for (BigInteger n = 2; n <= limit; n++)
			{
				BigInteger k = 0;
				BigInteger inc = 1;
				BigInteger m = 100;
				for (BigInteger i = 0; i < 100; i++)
				{
					//Debug.WriteLine((BigInteger) Math.Pow(10, n.ToString().Length));
					if (BigInteger.ModPow(n, i, m) == i)
					{
						k = i;
						while (m <= mLimit)
						{
							k = BigInteger.ModPow(n, k, m);
							m*= 10;
						}
						break;
					}
				}
				if (k != 0)
					while (k != BigInteger.ModPow(n, k, mLimit))
						k = BigInteger.ModPow(n, k, mLimit);
				sum += k;
				//Debug.WriteLine(n + " " + k);
				//Debug.WriteLine(n + "\t" + k + "\t" + BigInteger.ModPow(n,k,(BigInteger) Math.Pow(10,k.ToString().Length)));
			}
			Debug.WriteLine(sum);
		}
		

	}
}
