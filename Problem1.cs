using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem1
    {
        public static long Solution(long limit)
        {
            long sum = 0;
            // sum of arithmetic progression
            // n * (a_1 + a_n) / 2
            sum += ((long)limit - 1) / 3 * (3 + 999) / 2;
            sum += ((long)limit - 1) / 5 * (5 + 995) / 2;
            sum -= ((long)limit - 1) / 15 * (15 + 990) / 2;
            return sum;
        }
    }
}
