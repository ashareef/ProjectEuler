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
			BigInteger mLimit = 1000000000;
			BigInteger limit = 157;
			BigInteger sum = 0;

			for (BigInteger n = limit; n <= limit; n++)
			{
				BigInteger k = 0;
				BigInteger inc = 1;
				BigInteger m = 10;
                //for (BigInteger i = (BigInteger) Math.Pow(10, n.ToString().Length); i > 0; i--)
                for (BigInteger i = 1; i < 10; i++)
                {
					if (BigInteger.ModPow(n, i, m) == i)
					{
						m *= 10;
						k = BigInteger.ModPow(n, i, m);
						while (m < mLimit)
						{
							m *= 10;
							k = BigInteger.ModPow(n, k, m);
							
						}
						break;
					}
				
				}
                //Debug.WriteLine(n + " " + k);
				sum += k;
			}
			Debug.WriteLine(sum);
		}
		

	}
}
