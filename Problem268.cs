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
			long limit = 1000;
			List<long>[] n = new List<long>[limit];
			long sum = 0;
			
			for (long i = 0; i < limit; i++)
				n[i] = new List<long>();
			
			for (long i = 2; i < limit; i++)
				if (n[i].Count == 0)
					for (long j = i; j < limit; j += i)
						n[j].Add(i);
			
			for (long i = 0; i < limit; i++)
				if (n[i].Count >= 4)
					sum++;
			
			Debug.WriteLine(sum);

		}
		
		
	}
}
