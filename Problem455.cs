using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    public static class Problem455
    {
        public static void Solution()
        {
            BigInteger m = 1000000000;
            BigInteger limit = 10;
            BigInteger sum = 0;
            for (BigInteger n = 2; n <= limit; n++)
                for (BigInteger k = m - 1; k > 0; k--)
                    if (BigInteger.ModPow(n, k, m) == k)
                        sum += k;

            Debug.WriteLine(sum);
            //Debug.WriteLine(BigInteger.ModPow(4, 411728896, 1000000000));

        }

    }
}
