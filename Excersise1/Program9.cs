using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise9
{
    class Program9
    {
        static void Main(string[] args)
        {
            int a, sum = 0;
            Console.WriteLine("Enter a number you want"); a = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                sum += i;
                Console.Write("{0}, ", i);
            }
            Console.WriteLine("\nTong tu 1 den {0} la: {1}", a, sum );
            Console.WriteLine("Trung binh cong tu 1 den {0} la: {1}", a, (float)sum / a);

            Console.ReadLine();
        }
    }
}
