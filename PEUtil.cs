using System;
using System.Collections.Generic;
using System.Numerics;

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
		
		public static List<int> Primes(int n)
		{
			List<int> result = new List<int>();
			bool[] notPrimes = new bool[n];

			for (int i = 2; i < n; i++)
				for (int j = i + i; j < n; j += i)
					notPrimes[j] = true;

			for (int i = 2; i < n; i++)
				if (notPrimes[i] == false)
					result.Add(i);
			return result;
		}
		
		public static Dictionary<long, long> PrimeFactorizedFactorial(long n)
		{
			Dictionary<long, long> result = new Dictionary<long, long>();
			List<long> primes = Primes(n);
			foreach (var prime in primes)
			{
				long k = Nu(n, prime);
				if (k > 0)
					result.Add(prime, k);
			}
			return result;
		}
		
		public static Dictionary<long, long> PrimeFactorizedFactorial(long n, List<long> primes)
		{
			Dictionary<long, long> result = new Dictionary<long, long>();
			foreach (var prime in primes)
			{
				long k = Nu(n, prime);
				if (k > 0)
					result.Add(prime, k);
			}
			return result;
		}
		
		public static long Nu(long n, long p)
		{
			long result = 0;
			for (long i = 1; i <= Math.Log(n)/Math.Log(p); i++)
			{
				result += (long) Math.Floor(n / Math.Pow(p, i));
			}
			return result;
		}
		
		public static BigInteger NumOfMultiples(BigInteger n, BigInteger m)
		{
			BigInteger result = 0;
			result = BigInteger.Divide(n,m);
			return result;
		}
		
		public static long NumOfMultiples(long n, long m)
		{
			long result = 0;
			result = n / m;
			return result;
		}
	}
}
