using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler
{
	public static class Problem64
	{
		// http://web.math.princeton.edu/mathlab/jr02fall/Periodicity/mariusjp.pdf
		
		public static void Solution()
		{
			List<int> fraction = ContinuedFractionSqrt(13);
			foreach (var d in fraction) {
				Debug.WriteLine(d);
			}
		}
		
		public static List<int> ContinuedFractionSqrt(int n)
		{
			List<int> continuedFraction = new List<int>();
			double x = Math.Sqrt(n);
			for (int i = 0; i < 20; i++) {
				int a = (int) Math.Floor(x);
				x = 1 / (x - a);
				continuedFraction.Add(a);				
			}
			return continuedFraction;
		}
	}
}
