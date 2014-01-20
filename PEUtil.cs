using System;
using System.Collections.Generic;

namespace ProjectEuler
{
	/// <summary>
	/// Commonly used functions in Project Euler
	/// </summary>
	public static class PEUtil
	{
		public static List<long> Primes(long n)
        {
            List<long> result = new List<long>();
            bool[] notPrimes = new bool[n];

            for (long i = 2; i < n; i++)
                for (long j = i + i; j < n; j += i)
                    notPrimes[j] = true;

            for (long i = 2; i < n; i++)
                if (notPrimes[i] == false)
                    result.Add(i);
            return result;
        }
	}
}
