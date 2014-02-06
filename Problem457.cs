using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace ProjectEuler
{
	public static class Problem457
	{
//			Using Excel I calculated the values of f(n) mod p^2 to check for any patterns/relationships
// 		   	n	f(n)	2	3	5	7	11	13	17	19	23	29	. . .
//			1	-3		1	6	22	46	118	166	286	358	526	838
//			2	-3		1	6	22	46	118	166	286	358	526	838
//			3	-1		3	8	24	48	120	168	288	360	528	840
//			4	3		3	3	3	3	3	3	3	3	3	3
//			5	9		1	0	9	9	9	9	9	9	9	9
//			6	17		1	8	17	17	17	17	17	17	17	17
//			7	27		3	0	2	27	27	27	27	27	27	27
//			8	39		3	3	14	39	39	39	39	39	39	39
//			9	53		1	8	3	4	53	53	53	53	53	53
//			10	69		1	6	19	20	69	69	69	69	69	69
//			.
//			.
//			.
//			It can be seen that f(n) mod p^2 is cyclic with a period of p^2

		public static void Solution()
		{
			List<int> primes = PEUtil.Primes(10000000);
			Debug.WriteLine(primes[primes.Count - 1]);
			
		}
		
		public static int f(int n)
		{
			return n * n - 3 * n - 1;
		}
		
		public static int R(int p)
		{
			return 0;
		}
		
		public static HashSet<double> QuadraticRoots(int a, int b, int c)
		{
			HashSet<double> solutions = new HashSet<double>();
			double term = b * b - 4 * a * c;
			if (term < 0)
			{
				double solution1 = (- b + Math.Sqrt(term))/(2 * a);
				double solution2 = (- b - Math.Sqrt(term))/(2 * a);
				solutions.Add(solution1);
				solutions.Add(solution2);
			}
			return solutions;
		}
	}
}
