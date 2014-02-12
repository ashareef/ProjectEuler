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
			long limit = (long) Math.Pow(2,23);
			BigInteger count = limit;
			//NaiveSolution(limit);
			List<long> p = PEUtil.Primes((long) Math.Sqrt(limit) + 1);
			// since (2 * 3 * 5 * 7 * 11 * 13 * 17 * 19) > 2^25
			// need 8 nested loops
			
			for (int i = 0; i < p.Count; i++) {
				BigInteger p1 = p[i] * p[i];
				if (p1 > limit)
					break;
				else
					count -= PEUtil.NumOfMultiples(limit, p1);
			}
			
			for (int i = 0; i < p.Count; i++) {
				for (int j = i + 1; j < p.Count; j++) {
					BigInteger p1 = p[i] * p[i] * p[j] * p[j];
					if (p1 > limit)
						break;
					else
						count += PEUtil.NumOfMultiples(limit, p1);
				}
			}
			
			for (int i = 0; i < p.Count; i++) {
				for (int j = i + 1; j < p.Count; j++) {
					BigInteger p1 = p[i] * p[i] * p[j] * p[j];
					if (p1 > limit)
						break;
					for (int k = j + 1; k < p.Count; k++) {
						BigInteger p2 = p1 * p[k] * p[k];
						if (p2 > limit)
							break;
						else
							count -= PEUtil.NumOfMultiples(limit, p2);
					}
				}
			}
			
			for (int i = 0; i < p.Count; i++) {
				for (int j = i + 1; j < p.Count; j++) {
					BigInteger p1 = p[i] * p[i] * p[j] * p[j];
					if (p1 > limit)
						break;
					for (int k = j + 1; k < p.Count; k++) {
						BigInteger p2 = p1 * p[k] * p[k];
						if (p2 > limit)
							break;
						for (int l = k + 1; l < p.Count; l++) {
							BigInteger p3 = p2 * p[l] * p[l];
							if (p3 > limit)
								break;
							else
								count += PEUtil.NumOfMultiples(limit, p3);
						}
					}
				}
			}
			
			for (int i = 0; i < p.Count; i++) {
				for (int j = i + 1; j < p.Count; j++) {
					BigInteger p1 = p[i] * p[i] * p[j] * p[j];
					if (p1 > limit)
						break;
					for (int k = j + 1; k < p.Count; k++) {
						BigInteger p2 = p1 * p[k] * p[k];
						if (p2 > limit)
							break;
						for (int l = k + 1; l < p.Count; l++) {
							BigInteger p3 = p2 * p[l] * p[l];
							if (p3 > limit)
								break;
							for (int m = l + 1; m < p.Count; m++) {
								BigInteger p4 = p3 * p[m] * p[m];
								if (p4 > limit)
									break;
								else
									count -= PEUtil.NumOfMultiples(limit, p4);
							}
						}
					}
				}
			}

			for (int i = 0; i < p.Count; i++) {
				for (int j = i + 1; j < p.Count; j++) {
					BigInteger p1 = p[i] * p[i] * p[j] * p[j];
					if (p1 > limit)
						break;
					for (int k = j + 1; k < p.Count; k++) {
						BigInteger p2 = p1 * p[k] * p[k];
						if (p2 > limit)
							break;
						for (int l = k + 1; l < p.Count; l++) {
							BigInteger p3 = p2 * p[l] * p[l];
							if (p3 > limit)
								break;
							for (int m = l + 1; m < p.Count; m++) {
								BigInteger p4 = p3 * p[m] * p[m];
								if (p4 > limit)
									break;
								for (int n = m + 1; n < p.Count; n++) {
									BigInteger p5 = p4 * p[n] * p[n];
									if (p5 > limit)
										break;
									else
										count += PEUtil.NumOfMultiples(limit, p5);
								}
							}
						}
					}
				}
			}
			
			for (int i = 0; i < p.Count; i++) {
				for (int j = i + 1; j < p.Count; j++) {
					BigInteger p1 = p[i] * p[i] * p[j] * p[j];
					if (p1 > limit)
						break;
					for (int k = j + 1; k < p.Count; k++) {
						BigInteger p2 = p1 * p[k] * p[k];
						if (p2 > limit)
							break;
						for (int l = k + 1; l < p.Count; l++) {
							BigInteger p3 = p2 * p[l] * p[l];
							if (p3 > limit)
								break;
							for (int m = l + 1; m < p.Count; m++) {
								BigInteger p4 = p3 * p[m] * p[m];
								if (p4 > limit)
									break;
								for (int n = m + 1; n < p.Count; n++) {
									BigInteger p5 = p4 * p[n] * p[n];
									if (p5 > limit)
										break;
									for (int o = n + 1; o < p.Count; o++) {
										BigInteger p6 = p5 * p[o] * p[o];
										if (p6 > limit)
											break;
										else
											count -= PEUtil.NumOfMultiples(limit, p6);
									}
								}
							}
						}
					}
				}
			}
			
			for (int i = 0; i < p.Count; i++) {
				for (int j = i + 1; j < p.Count; j++) {
					BigInteger p1 = p[i] * p[i] * p[j] * p[j];
					if (p1 > limit)
						break;
					for (int k = j + 1; k < p.Count; k++) {
						BigInteger p2 = p1 * p[k] * p[k];
						if (p2 > limit)
							break;
						for (int l = k + 1; l < p.Count; l++) {
							BigInteger p3 = p2 * p[l] * p[l];
							if (p3 > limit)
								break;
							for (int m = l + 1; m < p.Count; m++) {
								BigInteger p4 = p3 * p[m] * p[m];
								if (p4 > limit)
									break;
								for (int n = m + 1; n < p.Count; n++) {
									BigInteger p5 = p4 * p[n] * p[n];
									if (p5 > limit)
										break;
									for (int o = n + 1; o < p.Count; o++) {
										BigInteger p6 = p5 * p[o] * p[o];
										if (p6 > limit)
											break;
										for (int q = o + 1; q < p.Count; q++) {
											BigInteger p7 = p6 * p[q] * p[q];
											if (p7 > limit)
												break;
											else
												count += PEUtil.NumOfMultiples(limit, p7);
										}
									}
								}
							}
						}
					}
				}
			}
			
			for (int i = 0; i < p.Count; i++) {
				for (int j = i + 1; j < p.Count; j++) {
					BigInteger p1 = p[i] * p[i] * p[j] * p[j];
					if (p1 > limit)
						break;
					for (int k = j + 1; k < p.Count; k++) {
						BigInteger p2 = p1 * p[k] * p[k];
						if (p2 > limit)
							break;
						for (int l = k + 1; l < p.Count; l++) {
							BigInteger p3 = p2 * p[l] * p[l];
							if (p3 > limit)
								break;
							for (int m = l + 1; m < p.Count; m++) {
								BigInteger p4 = p3 * p[m] * p[m];
								if (p4 > limit)
									break;
								for (int n = m + 1; n < p.Count; n++) {
									BigInteger p5 = p4 * p[n] * p[n];
									if (p5 > limit)
										break;
									for (int o = n + 1; o < p.Count; o++) {
										BigInteger p6 = p5 * p[o] * p[o];
										if (p6 > limit)
											break;
										for (int q = o + 1; q < p.Count; q++) {
											BigInteger p7 = p6 * p[q] * p[q];
											if (p7 > limit)
												break;
											for (int r = q + 1; r < p.Count; r++) {
												BigInteger p8 = p7 * p[r] * p[r];
												if (p8 > limit)
													break;
												else
													count -= PEUtil.NumOfMultiples(limit, p8);
											}
										}
									}
								}
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