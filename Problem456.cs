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
			int mx = 32323;
			int my = 30103;
			BigInteger count = 0;
			int[] xn = new int[mx];
			int[] yn = new int[my];
			for (int i = 1; i <= xn.Length; i++)
				xn[i - 1] = (int) BigInteger.ModPow(1248, i, 32323) - 16161;
			for (int i = 1; i <= yn.Length; i++)
				yn[i - 1] = (int) BigInteger.ModPow(8421, i, 30103) - 15051;
			
//			List<Point> p = new List<Point>();
//			for (int i = 0; i < n; i++)
//				p.Add(new Point(xn[i % mx], yn[i % my]));
			
			List<Point> points = new List<Point>();
			Dictionary<string, int> quadrants = new Dictionary<string, int>();
			for (int i = 0; i < n; i++) {
				Point p = new Point(xn[i % mx], yn[i % my]);
				points.Add(p);
			}

			Point o = new Point(0, 0);
			for (int i = 0; i < points.Count; i++){
				for (int j = i + 1; j < points.Count; j++){
					for (int k = j + 1; k < points.Count; k++) {
						if(ContainsOrigin(points[i], points[j], points[k])) {
							count++;
							// string s = QSort(Quadrant(points[i]), Quadrant(points[j]), Quadrant(points[k]));
							string s = QSort(FindN(points, points[i]), FindN(points, points[j]), FindN(points, points[k]));
							if (quadrants.ContainsKey(s))
								quadrants[s]++;
							else
								quadrants.Add(s, 1);
							
						}
					}
				}
			}
			
			Debug.WriteLine(count);
			foreach (var key in quadrants.Keys) {
				Debug.WriteLine(key + " " + quadrants[key]);
			}
		}
		
		public static int FindN(List<Point> points, Point p)
		{
			return points.IndexOf(p);
		}
		
		public static string QSort(int a, int b, int c)
		{
			int max = a;
			int med = b;
			int min = c;
			
			if( a > b ){
				if( a > c ){
					max = a;
					if( b > c ){
						med = b;
						min = c;
					}else{
						med = c;
						min = b;
					}
				}else{
					med = a;
					if( b > c ){
						max = b;
						min = c;
					}else{
						max = c;
						min = b;
					}
				}
			}else{
				if( b > c ){
					max = b;
					if( a > c ){
						med = a;
						min = c;
					}else{
						med = c;
						min = a;
					}
				}else{
					med = b;
					max = c;
					min = a;
				}
			}
			return min + "" + med + "" + max;
		}
		
		public static int Quadrant(Point p)
		{
			if (p.X >= 0 && p.Y > 0)
				return 1;
			else if (p.X < 0 && p.Y >= 0)
				return 2;
			else if (p.X <= 0 && p.Y < 0)
				return 3;
			else if (p.X > 0 && p.Y <= 0)
				return 4;
			return -1;
		}
		
		public static bool AllDifferentPoints(Point p1, Point p2, Point p3)
		{
			return !(p1.Equals(p2) || p2.Equals(p3) || p1.Equals(p3));
		}
		
		public static bool ContainsOrigin(Point p1, Point p2, Point p3)
		{
			Point o = new Point(0, 0);
			if (T(p1, p2, p3) == T(p1, p2, o) + T(p1, o, p3) + T(o, p2, p3))
				return true;
			return false;
		}
		
		public static long T(Point p1, Point p2, Point p3)
		{
			return (long) Math.Abs((p1.X - p3.X) * (p2.Y - p1.Y) - (p1.X - p2.X) * (p3.Y - p1.Y));
		}
	}
}

#region a
//			List<Point> p = new List<Point>();
//			for (int i = 0; i < n; i++)
//				p.Add(new Point(xn[i % mx], yn[i % my]));
//
//			Point o = new Point(0, 0);
//			for (int i = 0; i < p.Count; i++){
//				for (int j = i + 1; j < p.Count; j++){
//					for (int k = j + 1; k < p.Count; k++) {
//						if(ContainsOrigin(p[i], p[j], p[k])) {
//							count++;
//						}
//					}
//				}
//			}


//List<Point> q1 = new List<Point>();
//			List<Point> q2 = new List<Point>();
//			List<Point> q3 = new List<Point>();
//			List<Point> q4 = new List<Point>();
//			for (int i = 0; i < n; i++) {
//				int x = xn[i % mx];
//				int y = yn[i % my];
//				if (x >= 0 && y > 0)
//					q1.Add(new Point(x, y));
//				else if (x < 0 && y >= 0)
//					q2.Add(new Point(x, y));
//				else if (x <= 0 && y < 0)
//					q3.Add(new Point(x, y));
//				else if (x > 0 && y <= 0)
//					q4.Add(new Point(x, y));
//			}
//			foreach (var p1 in q1)
//				foreach (var p2 in q2)
//					foreach (var p3 in q3)
//						if (ContainsOrigin(p1, p2, p3))
//							count++;
//			foreach (var p1 in q1)
//				foreach (var p2 in q2)
//					foreach (var p3 in q4)
//						if (ContainsOrigin(p1, p2, p3))
//							count++;
//			foreach (var p1 in q2)
//				foreach (var p2 in q3)
//					foreach (var p3 in q4)
//						if (ContainsOrigin(p1, p2, p3))
//							count++;
//			foreach (var p1 in q1)
//				foreach (var p2 in q3)
//					foreach (var p3 in q4)
//						if (ContainsOrigin(p1, p2, p3))
//							count++;
//
//			foreach (var p1 in q1)
//				foreach (var p2 in q3)
//					foreach (var p3 in q3)
//						if (p2.Equals(p3) == false)
//							if (ContainsOrigin(p1, p2, p3))
//								count++;
//			foreach (var p1 in q2)
//				foreach (var p2 in q4)
//					foreach (var p3 in q4)
//						if (p2.Equals(p3) == false)
//							if (ContainsOrigin(p1, p2, p3))
//								count++;
//			foreach (var p1 in q3)
//				foreach (var p2 in q1)
//					foreach (var p3 in q1)
//						if (p2.Equals(p3) == false)
//							if (ContainsOrigin(p1, p2, p3))
//								count++;
//			foreach (var p1 in q4)
//				foreach (var p2 in q2)
//					foreach (var p3 in q2)
//						if (p2.Equals(p3) == false)
//							if (ContainsOrigin(p1, p2, p3))
//								count++;
#endregion