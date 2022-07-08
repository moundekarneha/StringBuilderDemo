using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringBuilderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for(int i=1; i <= 100000; i++)
            {
                s=s+i;  // 100001 copies will create for this - with string
            }
            sw1.Stop();

            Stopwatch sw2 = new Stopwatch();
            StringBuilder sb = new StringBuilder(10000);
            sw2.Start();
            for (int i = 1; i <= 100000; i++)
            {
                sb.Append(i);  // only one copy copies will create for this - with stringBuilder
            }
            sw2.Stop();

            Console.WriteLine("Elapased time of s string = "+sw1.ElapsedMilliseconds);
            Console.WriteLine("Elapsed time of string builder = "+sw2.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
