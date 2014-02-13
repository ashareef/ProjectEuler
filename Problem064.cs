using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler
{
	public static class Problem064
	{
		// http://web.math.princeton.edu/mathlab/jr02fall/Periodicity/mariusjp.pdf
		// http://en.wikipedia.org/wiki/Methods_of_computing_square_roots#Continued_fraction_expansion
		
		public static void Solution()
		{
			int limit = 10000;
			int count = 0;
			for (int n = 1; n <= limit; n++) {
				List<int> f = ContinuedFractionSqrt(n);
				if (f.Count % 2 == 0)
					count++;
			}
			Debug.WriteLine(count);
		}
		
		public static List<int> ContinuedFractionSqrt(int n)
		{
			List<int> continuedFraction = new List<int>();
			int m = 0;
			int d = 1;
			int a0 = (int) Math.Floor(Math.Sqrt(n));
			int a = a0;
			continuedFraction.Add(a);
			
			if (a0 * a0 != n) {				
				while (a != 2 * a0) {
					m = d * a - m;
					d = (n - m * m) / d;
					a = (int) Math.Floor((double) (a0 + m) / d);
					continuedFraction.Add(a);
				}
			}
			
			return continuedFraction;
		}
	}
}
