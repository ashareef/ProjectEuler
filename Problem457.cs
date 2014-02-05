using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace ProjectEuler
{
	public static class Problem457
	{
		public static void Solution()
		{
			List<int> primes = PEUtil.Primes(10000000);
		}
		
		public static int f(int n)
		{
			return n * n - 3 * n - 1;
		}
		
		public static int R(int p)
		{
			return 0;
		}
	}
}
