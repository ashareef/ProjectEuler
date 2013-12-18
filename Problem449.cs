using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem449
    {
        // dt - interval for theta
        public static void solution(double dt)
        {
            // major and minor axes
            double a;
            double b;
            // points on ellispoid
            double y0;
            double z0;
            // points on surface of chocolate
            double y;
            double z;
            // previous points on surface of chocolate
            double prevY = 0;
            double prevZ = 0;
            // components
            double ny;
            double nz;
            double n;
            double v = 0;
            double t = 0;
            double sint;
            double cost;

            a = 3;
            b = 1;
            z = 0;
            while (t <= Math.PI / 2.0)
            {
                sint = Math.Sin(t);
                cost = Math.Cos(t);

                y0 = a * cost;
                z0 = b * sint;

                ny = b * cost;
                nz = a * sint;
                n = Math.Sqrt((ny * ny) + (nz * nz));
                ny = ny / n;
                nz = nz / n;

                y = y0 + ny;

                v = v + Math.PI * (z0 + nz - z) / 12.0 * (4 * y * y + 4 * y * prevY + 4 * prevY * prevY);

                z = z0 + nz;
                t += dt;
                prevY = y;
                prevZ = z;
            }

            v = v * 2;

            Debug.WriteLine(v - (4.0 / 3.0 * Math.PI * a * a * b));
            Debug.WriteLine(60.35475635);
        }

    }
}
