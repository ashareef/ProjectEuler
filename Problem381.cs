﻿// Azher Shareef
// 2/21/2014

using System;

namespace ProjectEuler
{
	#region q
	/// <summary>
	/// (prime-k) factorial
	/// </summary>
	/// For a prime p let S(p) = (∑(p-k)!) mod(p) for 1 ≤ k ≤ 5.
	/// For example, if p=7,
	/// (7-1)! + (7-2)! + (7-3)! + (7-4)! + (7-5)! = 6! + 5! + 4! + 3! + 2! = 720+120+24+6+2 = 872.
	/// As 872 mod(7) = 4, S(7) = 4.
	/// It can be verified that ∑S(p) = 480 for 5 ≤ p < 100.
	/// Find ∑S(p) for 5 ≤ p < 108.
	#endregion
	
	public static class Problem381
	{
		public static void Solution()
		{
			NaiveSolution();
		}
		
		public static void NaiveSolution
		{
			
		}
	}
}
