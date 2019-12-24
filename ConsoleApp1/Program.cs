using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //start targil #2
            Console.WriteLine("enter number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int days = number / 86400;
            number = number % 86400;
            int houers = number / 3600;
            number = number % 3600;
            int min = number / 60;
            number = number % 60;
            int sec = number / 1;
            number = number % 1;

            Console.WriteLine($"days:{days} / houers:{houers} / min:{min} / sec:{sec}");
            Console.WriteLine();
            //end

            //start targil #3
            Console.WriteLine("enter a number:");

            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    if (j <= i)
                        Console.Write(j);
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }

            //end
        }
    }
}
