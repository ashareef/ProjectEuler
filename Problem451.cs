using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    public static class Problem451
    {
        public static void Solution()
        {
            long i = 15;
            for (long n = 0; n < i; n++)
            {
                if (gcd(n, i) == 1)
                {
                    for (long k = 0; k < i ; k++)
                    {

                    }
                }
            }
        }

        public static long gcd(long a, long b)
        {
            while (b != 0)
            {
                long tmp = b;
                b = a % b;
                a = tmp;
            }

            return a;
        }
        // Modular multiplicative inverse using extended Euclidean algorithm.
        private static BigInteger ModInverse(BigInteger a, BigInteger b)
        {
            BigInteger dividend = a % b;
            BigInteger divisor = b;

            BigInteger last_x = BigInteger.One;
            BigInteger curr_x = BigInteger.Zero;

            while (divisor.Sign > 0)
            {
                BigInteger quotient = dividend / divisor;
                BigInteger remainder = dividend % divisor;
                if (remainder.Sign <= 0)
                {
                    break;
                }

                /* This is quite clever, in the algorithm in form
                 * ax + by = gcd(a, b) we only keep track of the
                 * value curr_x and the last_x from last iteration,
                 * the y value is ignored anyway. After remainder
                 * runs to zero, we get our inverse from curr_x */
                BigInteger next_x = last_x - curr_x * quotient;
                last_x = curr_x;
                curr_x = next_x;

                dividend = divisor;
                divisor = remainder;
            }

            if (divisor != BigInteger.One)
            {
                throw new Exception("Numbers a and b are not relatively primes");
            }
            return (curr_x.Sign < 0 ? curr_x + b : curr_x);
        }
    }
}
