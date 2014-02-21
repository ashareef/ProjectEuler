// Azher Shareef
// 2/21/2014

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace ProjectEuler
{
	#region q
	/// <summary>
	/// (prime-k) factorial
	/// </summary>
	/// For a prime p let S(p) = (∑(p-k)!) mod(p) for 1 ≤ k ≤ 5.
	/// For example, if p=7,
	/// (7-1)! + (7-2)! + (7-3)! + (7-4)! + (7-5)! = 6! + 5! + 4! + 3! + 2! = 720+120+24+6+2 = 872.
	/// As 872 mod(7) = 4, S(7) = 4.
	/// It can be verified that ∑S(p) = 480 for 5 ≤ p < 100.
	/// Find ∑S(p) for 5 ≤ p < 10^8.
	#endregion
	
	public static class Problem381
	{
		public static void Solution()
		{
			NaiveSolution();
		}
		
		public static void NaiveSolution()
		{
			List<long> primes = PEUtil.Primes((long) 10000);
			BigInteger sum = 0;
			primes.RemoveAt(0); // remove 2
			primes.RemoveAt(0); // remove 3
			foreach (var p in primes) {
				sum += BigInteger.ModPow(S(p), 1, p);
			}
			Debug.WriteLine(sum);
		}
		
		public static BigInteger S(BigInteger p)
		{
			BigInteger sum = 0;
			for (BigInteger k = 1; k <= 5; k++) {
				sum += Factorial(p - k);
//				Debug.WriteLine((p-k).ToString());
			}
			return sum;
		}
		
		public static BigInteger Factorial(BigInteger n)
		{
			BigInteger product = 1;
			for (BigInteger i = 2; i <= n; i++) {
				product *= i;
//				Debug.WriteLine(n + " " + i + " " + product);
			}
			return product;
		}
		
	}
}
