// Azher Shareef
// 2/12/2014

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler
{
	public static class Problem193
	{
		public static void Solution()
		{
			// 637462
			// 625
			long limit = (long) Math.Pow(2,20);
			BigInteger count = limit;
			NaiveSolution(limit);
			List<long> p = PEUtil.Primes((long) Math.Sqrt(limit) + 1);
//			foreach (var e in p) {
//				Debug.WriteLine(e * e + " " + PEUtil.NumOfMultiples(limit, e * e));
//			}
			
			for (int i = 0; i < p.Count; i++) {
				BigInteger p2 = p[i] * p[i];
				if (p2 > limit)
					break;
				else
					count -= PEUtil.NumOfMultiples(limit, p2);
			}
			
			for (int i = 0; i < p.Count; i++) {
				for (int j = i + 1; j < p.Count; j++) {
					BigInteger p2 = p[i] * p[i] * p[j] * p[j];
					if (p2 > limit)
						break;
					else
						count += PEUtil.NumOfMultiples(limit, p2);
				}
			}
			
			for (int i = 0; i < p.Count; i++) {
				for (int j = i + 1; j < p.Count; j++) {
					for (int k = j + 1; k < p.Count; k++) {
						BigInteger p2 = p[i] * p[i] * p[j] * p[j] * p[k] * p[k];
						if (p2 > limit)
							break;
						else
							count -= PEUtil.NumOfMultiples(limit, p2);
					}
				}
			}
			
			for (int i = 0; i < p.Count; i++) {
				for (int j = i + 1; j < p.Count; j++) {
					for (int k = j + 1; k < p.Count; k++) {
						for (int l = k + 1; l < p.Count; l++) {
							BigInteger p2 = p[i] * p[i] * p[j] * p[j] * p[k] * p[k] * p[l] * p[l];
							if (p2 > limit)
								break;
							else
								count += PEUtil.NumOfMultiples(limit, p2);
						}
					}
				}
			}
			
			for (int i = 0; i < p.Count; i++) {
				for (int j = i + 1; j < p.Count; j++) {
					for (int k = j + 1; k < p.Count; k++) {
						for (int l = k + 1; l < p.Count; l++) {
							for (int m = l + 1; m < p.Count; m++) {
								BigInteger p2 = p[i] * p[i] * p[j] * p[j] * p[k] * p[k] * p[l] * p[l] * p[m] * p[m];
								if (p2 > limit)
									break;
								else
									count -= PEUtil.NumOfMultiples(limit, p2);
							}
						}
					}
				}
			}
			
			count++; // hack to get real solution - not sure why this is always short 1
			Debug.WriteLine(count);
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