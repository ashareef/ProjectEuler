﻿// Azher Shareef
// 2/13/2014

using System;
using System.Diagnostics;

namespace ProjectEuler
{
	/// <summary>
	/// Even Fibonacci numbers
	/// </summary>
	/// Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
	/// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
	/// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
	
	public static class Problem2
	{
		public static void Solution()
		{
			int limit = 4000000;
			int fn = 1;
			int fn_1 = 1;
			int sum = 0;
	
			while (fn_1 < limit) {
				int temp = fn_1;
				fn_1 += fn;
				fn = temp;
				if (fn_1 % 2 == 0)	// only add even numbers
					sum += fn_1;
			}
	
			Debug.WriteLine(sum);
		}
	}
}
