using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise4
{
    class Program4
    {
        public static void ptb2(float a, float b, float c)
        {
            if (a == 0)
                Console.WriteLine("Chuyen thanh phuong trinh bac nhat roi :D :D ");
            else
            {
                float delta = b * b - 4 * a * c;
                Console.WriteLine(delta);
                if (delta < 0) Console.WriteLine("Phuong trinh vo nghiem roi");
                else if( delta == 0) Console.WriteLine("Phuong trinh co nghiem kep la x1 = x2 = " + -b/2*a);
                else
                {
                    Console.WriteLine("Phuong trinh 2 nghiem la: ");
                    Console.WriteLine("x1 = {0}", (-b - Math.Sqrt(delta)) / 2 * a);
                    Console.WriteLine("x2 = {0}", (-b + Math.Sqrt(delta)) / 2 * a);
                }
            }
            return;
        }
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("--------- Welcome to resolver for ax^2 + bx + c = 0 ----------");

            Console.WriteLine("Enter a param: "); a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter b param: "); b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter c param: "); c = float.Parse(Console.ReadLine());

            ptb2(a, b, c);

            Console.ReadLine();
        }
    }
}
