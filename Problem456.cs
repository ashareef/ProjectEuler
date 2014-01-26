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
			int n = 600;
			List<Point> p = new List<Point>();
			Point o = new Point(0, 0);
			HashSet<Point> h = new HashSet<Point>();
			
			for (int i = 1; i <= n; i++)
			{
				int x = (int) BigInteger.ModPow(1248, i, 32323) - 16161;
				int y = (int) BigInteger.ModPow(8421, i, 30103) - 15051;
				//p.Add(new Point(x, y));
				h.Add(new Point(x, y));
			}
			
			long count = 0;
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
			
			Debug.WriteLine(count);
		}
		
		public static double T(Point p1, Point p2, Point p3)
		{
			return Math.Abs((p1.X - p3.X) * (p2.Y - p1.Y) - (p1.X - p2.X) * (p3.Y - p1.Y));
		}
	}
}
