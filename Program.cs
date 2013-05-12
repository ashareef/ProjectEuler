using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            long answer = Problem1.Solution(1000);
            Debug.WriteLine(answer);

            sw.Stop();
            Debug.WriteLine("elapsed: {0}", sw.Elapsed);
        }
    }
}
