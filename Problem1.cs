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
            for (long i = 0; i < limit; i++) {
                if ((i % 3 == 0) || (i % 5 == 0)) {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
