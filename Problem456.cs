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
			int n = 60000;
			int mx = 32323;
			int my = 30103;
			int[] xn = new int[mx];
			int[] yn = new int[my];
			for (int i = 0; i < xn.Length; i++)
				xn[i] = (int) BigInteger.ModPow(1248, i, 32323) - 16161;
			for (int i = 0; i < yn.Length; i++)
				yn[i] = (int) BigInteger.ModPow(8421, i, 30103) - 15051;
			
			List<Point> p = new List<Point>();
			Point o = new Point(0, 0);
//			for (int i = 0; i < n; i++)
//				p.Add(new Point(xn[i % mx], yn[i % my]));
			
			List<Point> q1 = new List<Point>();
			List<Point> q2 = new List<Point>();
			List<Point> q3 = new List<Point>();
			List<Point> q4 = new List<Point>();
			for (int i = 0; i < n; i++) {
				int x = xn[i % mx];
				int y = yn[i % my];
				if (x >= 0 && y > 0)
					q1.Add(new Point(x, y));
				else if (x < 0 && y >= 0)
					q2.Add(new Point(x, y));
				else if (x <= 0 && y < 0)
					q3.Add(new Point(x, y));
				else if (x > 0 && y <= 0)
					q4.Add(new Point(x, y));
			}
				
			
			
//			long count = 0;
//			for (int i = 0; i < p.Count; i++) {
//				for (int j = i + 1; j < p.Count; j++) {
//					for (int k = j + 1; k < p.Count; k++) {
//						if (T(p[i], p[j], p[k]) == T(p[i], p[j], o) + T(p[i], o, p[k]) + T(o, p[j], p[k])) {
//							//count++;
//						}
//						count++;
//					}
//				}
//			}
			
//			long count = 0;
//			for (int i = 0; i < p.Count; i++) {
//				
//			}
		}
		
		public static double T(Point p1, Point p2, Point p3)
		{
			return Math.Abs((p1.X - p3.X) * (p2.Y - p1.Y) - (p1.X - p2.X) * (p3.Y - p1.Y));
		}
	}
}
