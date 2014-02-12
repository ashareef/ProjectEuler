// Azher Shareef
// 2/12/2014

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler
{
	/// <summary>
	/// Investigating a Prime Pattern
	/// </summary>
	/// The smallest positive integer n for which the numbers n^2+1, n^2+3, n^2+7, n^2+9, n^2+13, and n^2+27 are consecutive primes is 10. The sum of all such integers n below one-million is 1242490.
	/// What is the sum of all such integers n below 150 million?

	public static class Problem146
	{
		// n^2 + x is prime, where x is odd
		// n^2 must be even, therefore n is even
		public static void Solution()
		{
			long limit = 1000000;
			NaiveSolution(limit);
		}
		
		public static void NaiveSolution(long limit)
		{
			List<long> p = PEUtil.Primes(limit);
		}			
	}
}
