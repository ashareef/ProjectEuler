using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace ProjectEuler
{
	/// <summary>
	/// Description of Problem456.
	/// </summary>
	public static class Problem456
	{
		public static void Solution()
		{
			int n = 8;
			HashSet<Point> points = new HashSet<Point>();
			
			for (int i = 1; i <= n; i++)
			{
				int x = (int) BigInteger.ModPow(1248, i, 32323) - 16161;
				int y = (int) BigInteger.ModPow(8421, i, 30103) - 15051;
				points.Add(new Point(x, y));
			}
			
			foreach (var p1 in points) {
				foreach (var p2 in points) {
					foreach (var p3 in points) {
						if (!(p1.Equals(p2) || p2.Equals(p3) || p1.Equals(p3)))
						{
								
						}
					}
				}
			}
		}
	}
}
