using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler
{
	/// <summary>
	/// Counting numbers with at least four distinct prime factors less than 100
	/// </summary>
	/// 
	// It can be verified that there are 23 positive integers less than 1000 that are divisible by at least four distinct primes less than 100.
	// Find how many positive integers less than 10^16 are divisible by at least four distinct primes less than 100.
	public static class Problem268
	{
		public static void Solution()
		{

		}
		
		public static void NaiveSolution()
		{
			long limit = 1000;
			long sum = 0;
			List<long>[] n = new List<long>[limit];
			List<long> primes = PEUtil.Primes(100);
			
			for (long i = 0; i < limit; i++)
				n[i] = new List<long>();
			
			foreach (var prime in primes)
				for (long j = prime; j < limit; j += prime)
					n[j].Add(prime);
			
			for (long i = 0; i < limit; i++)
				if (n[i].Count >= 4)
					sum++;
			
			Debug.WriteLine(sum);
		}
		
		
	}
}
