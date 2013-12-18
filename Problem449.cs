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
        public static void Solution(double dt)
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
            // components for normal vector
            double ny;
            double nz;
            // magnitude of normal vector
            double n;
            // volume
            double v = 0;
            // angle in radians
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

                // solving by taking x = 0, since x^2 + y^2 will give r^2 of the circle to approximate slice of the ellipsoid
                // points on the ellipse 
                y0 = a * cost;
                z0 = b * sint;

                // normal unit vector components perpendicular to the tangent
                ny = b * cost;
                nz = a * sint;
                n = Math.Sqrt((ny * ny) + (nz * nz));
                ny = ny / n;
                nz = nz / n;

                // y component on the surface of chocolate
                y = y0 + ny;

                // approximating volume by slicing ellispoid into "half" cones
                v = v + Math.PI * (z0 + nz - z) / 12.0 * (4 * y * y + 4 * y * prevY + 4 * prevY * prevY);

                // z component on the surface of chocolate
                z = z0 + nz;

                t += dt;
                prevY = y;
                prevZ = z;
            }

            // double the volume since we only looked at 1 quadrant of ellipse (0 to Pi radians) then revolved it around (only half ellipsoid)
            v = v * 2;

            // subtracting volume of the center to get the volume of chocolate
            Debug.WriteLine(v - (4.0 / 3.0 * Math.PI * a * a * b));
        }

    }
}
