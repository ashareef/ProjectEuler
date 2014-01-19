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
            BigInteger mLimit = 1000000000;
            BigInteger limit = 4;
            BigInteger sum = 0;

            for (BigInteger n = limit; n <= limit; n++)
            {
                BigInteger m = 10;
                BigInteger k = 1;
                BigInteger inc = 1;
                BigInteger kMax = k;
                while (m < mLimit)
                {                 
                    if (BigInteger.ModPow(n, k, m) == k)
                    {
                        inc *= 10;
                        m *= 10;
                        kMax = k;
                        k += inc;
                    }
                    else
                    {
                        k += inc;
                    }
                }
                Debug.WriteLine(kMax);
            }
   
        }


    }
}
