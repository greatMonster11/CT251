using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise8
{
    class Program8
    {
        static void Main(string[] args)
        {
            int a, sum1 = 0;
            float sum2 = 0;
            Console.WriteLine("Enter a number you want: "); a = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                sum1 += i;
                sum2 += (float) 1/i;
            }
            Console.WriteLine("Sum of 1 + 2 + 3 + ... + N = {0}", sum1);
            Console.WriteLine("Sum of 1 + 1/2 + 1/3 + ... + 1/N = {0}", sum2);

            Console.ReadLine();
        }
    }
}
