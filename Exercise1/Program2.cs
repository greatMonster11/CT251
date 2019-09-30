using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise2
{
    class Program2
    {
        public static string ranking(float a) {
            return a > 8.0 ? "Gioi" : a > 6.5 && a < 8 ? "Kha" : a >= 5 && a < 6.5 ? "Trung Binh" : "Yeu" ;
        }
        static void Main(string[] args)
        {
            float score;
            string strScore, name;

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your score: ");
            strScore = Console.ReadLine();
            score = float.Parse(strScore);

            Console.WriteLine("Hello: " + name);
            Console.WriteLine("You are: " + ranking(score));

            Console.ReadLine();
        }
    }
}
