﻿// Azher Shareef
// 2/12/2014

using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace ProjectEuler
{
	public static class Problem193
	{
		public static void Solution()
		{
			//2^20 => 637462 elapsed: 00:00:00.2130239
			NaiveSolution((long) Math.Pow(2,20));
		}
		
		public static void NaiveSolution(long limit)
		{
			List<long> primes = PEUtil.Primes((long) Math.Sqrt(limit)+1);
			bool[] notSquareFree = new bool[limit + 1];
			long count = 0;
			foreach (var p in primes) {
				long p2 = p * p;
				for (long i = p2; i <= limit; i += p2)
					notSquareFree[i] = true;
			}
			foreach (var e in notSquareFree)
				if (!e)
					count++;
			Debug.WriteLine(count);
		}
	}
}



























/// <summary>
/// Squarefree Numbers
/// </summary>
/// A positive integer n is called squarefree, if no square of a prime divides n, thus 1, 2, 3, 5, 6, 7, 10, 11 are squarefree, but not 4, 8, 9, 12.
/// How many squarefree numbers are there below 2^50?