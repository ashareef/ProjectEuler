// Azher Shareef
// 2/18/2014

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler
{
	#region q
	/// <summary>
	/// Prime pair connection
	/// </summary>
	/// Consider the consecutive primes p1 = 19 and p2 = 23. It can be verified that 1219 is the smallest number such that the last digits are formed by p1 whilst also being divisible by p2.
	/// In fact, with the exception of p1 = 3 and p2 = 5, for every pair of consecutive primes, p2 > p1, there exist values of n for which the last digits are formed by p1 and n is divisible by p2. Let S be the smallest of these values of n.
	/// Find ∑ S for every pair of consecutive primes with 5 ≤ p1 ≤ 1000000.
	#endregion
	
	public static class Problem134
	{
		public static void Solution()
		{
			List<int> p = PEUtil.Primes(100);
			long count = 0;
			for (int i = 2; i < p.Count - 1; i++) {
				Debug.WriteLine(p[i] + " " + p[i+1]);
			}
			
			Debug.WriteLine(p.Count);
			Debug.WriteLine(count);
		}
	}
}
