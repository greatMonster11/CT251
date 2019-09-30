using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise6
{
    class Program6
    {
        public static void KTNT(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine("{0} khong phai la so nguyen to", a);
                    return;
                }
                
            }
            Console.WriteLine("{0} la so nguyen to nhe !!!", a);
            return;
        }
        static void Main(string[] args)
        {

            int a;
            Console.WriteLine("Nhap vao mot so: "); a = Int32.Parse(Console.ReadLine());

            KTNT(a);
            Console.ReadLine();
        }
    }
}
