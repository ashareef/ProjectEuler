// Azher Shareef
// 2/11/2014

using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace ProjectEuler
{
	/// <summary>
	/// Find the smallest x + y + z with integers x > y > z > 0 such
	/// that x + y, x − y, x + z, x − z, y + z, y − z are all perfect squares.
	/// </summary>
	/// x + y = a	x - y = b
	/// x + z = c	x - z = d
	/// y + z = e	y - z = f
	/// 
	/// a - c = f
	/// c - e = b
	/// d + e = a
	/// 
	///	a + b 	= x + y + x - y 
	///	c + d	= 2x
	/// x		= (c + d)/2
	///
	/// y		= a - x
	/// 		= a - (c + d)/2
	/// 
	/// z		= e - a + (c + d)/2
	/// 
	
	

	public static class Problem142
	{
		public static void Solution()
		{
			int limit = 1000;
			int c = 0;
			for (int y = 1; y < limit; y++) {
				for (int x = y + 1; x < limit; x++) {
//					if (IsSquare(x*x - y*y))
					if (IsSquare(x + y) && IsSquare(x - y))
					{
//						Debug.WriteLine(x + " " + y);
						c++;
					}
				}
			}
			Debug.WriteLine(c);
		}

		public static bool IsSquare(int n)
		{
			HashSet<int> d = new HashSet<int>();
			if (n == 0 || n == 1)
			{
				return true;
			}
			else if (n > 1) {
				int x = n;
				d.Add(x);
				while (x * x != n) {
					x = (x + (n/x))/2;
					if (d.Contains(x)) {
						return false;
					}
					d.Add(x);
				}
				return true;
			}
			return false;
		}
	}
}
