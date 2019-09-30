using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise7
{
    class Program7
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter which year you want to check: ");
            year = Int32.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("This is a leaf year");
            }
            else
            {
                Console.WriteLine("This is not a leaf year");

            }
            Console.ReadLine();
        }
    }
}
