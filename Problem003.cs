// Azher Shareef
// 2/13/2014

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler
{
	/// <summary>
	/// Largest prime factor
	/// </summary>
	/// The prime factors of 13195 are 5, 7, 13 and 29.
	/// What is the largest prime factor of the number 600851475143 ?
	
	public static class Problem003
	{
		public static void Solution()
		{
			long limit = 600851475143;
			List<long> primes = PEUtil.Primes((long) Math.Sqrt(limit) + 1); // largest prime factor a number can have is < sqrt(number)
			for (int i = primes.Count - 1; i > 0; i--) {
				if (limit % primes[i] == 0) {
					Debug.WriteLine(primes[i]);
					break;
				}
			}
		}
	}
}
