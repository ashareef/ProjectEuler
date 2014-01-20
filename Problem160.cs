using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace ProjectEuler
{
	/// <summary>
	/// Factorial trailing digits
	/// </summary>
	/// 
	// For any N, let f(N) be the last five digits before the trailing zeroes in N!.
	// For example,
	// 9! = 362880 so f(9)=36288
	// 10! = 3628800 so f(10)=36288
	// 20! = 2432902008176640000 so f(20)=17664
	// Find f(1,000,000,000,000)
	
	public static class Problem160
	{
		public static void Solution()
		{
			long limit = 10;
			Dictionary<long, long> primeFactors = PEUtil.PrimeFactorizedFactorial(limit);
			long m = 100000;
			long product = 1;
			primeFactors[2] -= primeFactors[5];
			primeFactors.Remove(5);
			foreach (var factor in primeFactors.Keys)
				product *= (long) BigInteger.ModPow((BigInteger) factor, (BigInteger) primeFactors[factor], (BigInteger) m);
			Debug.WriteLine(product);
		}		
	}
}

