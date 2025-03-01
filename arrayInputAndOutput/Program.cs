using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayInputAndOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первое число:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите второе число:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите третье число:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите четвертое число:");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите пятое число:");
            int num5 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"вывод:{num1} {num2} {num3} {num4} {num5}");
            }




        }
    }
}
