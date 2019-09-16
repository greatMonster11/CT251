using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise3
{
    class Program3
    {
        public static float ptb1(float a, float b)
        {
            if (a == 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh co nghiem la: x = " + -b / a);
            }
                return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("------- Welcome to resolever ax + b = 0 ------ ");
            string inputA, inputB;
            Console.WriteLine("Enter a param: ");
            inputA = Console.ReadLine();
            Console.WriteLine("Enter b param: ");
            inputB = Console.ReadLine();

            ptb1(float.Parse(inputA), float.Parse(inputB));
          
            Console.ReadLine();
        }
    }
}
