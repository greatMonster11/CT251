using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise5
{
    class Program5
    {
        static void Main(string[] args)
        {
            int a = 0;
            do
            {
                Console.WriteLine("Nhap vao mot so nguyen duong: ");
                a = Int32.Parse(Console.ReadLine());
            } while (a <= 0);

            Console.ReadLine();
        }
    }
}
