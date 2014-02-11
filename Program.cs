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
        public static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
			
            Problem142.Solution();
            
            sw.Stop();
            Debug.WriteLine("elapsed: {0}", sw.Elapsed);
        }
    }
}
