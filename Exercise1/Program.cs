using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise1
{
    class Program
    {
        public static int maxOfThree(int a, int b, int c)
        {
            return a > b && a > c ? a : b > c ? b : c; 
        }
        static void Main(string[] args)
        {
            int a, b, c, max;
            string inputA = Console.ReadLine();
            string inputB = Console.ReadLine();
            string inputC = Console.ReadLine();
            // Convert into integer
            a = Int32.Parse(inputA);
            b = Int32.Parse(inputB);
            c = Int32.Parse(inputC);

            max = maxOfThree(a, b, c);
            Console.WriteLine("So lon nhat trong ba so la: " + max);

            Console.ReadLine();
        }
    }
}
