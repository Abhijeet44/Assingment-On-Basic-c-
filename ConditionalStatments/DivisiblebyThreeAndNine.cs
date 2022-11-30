using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalStatments
{
    class DivisiblebyThreeAndNine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int n = int.Parse(Console.ReadLine());

            if(n % 3 == 0 && n % 9 == 0)
            {
                Console.WriteLine("Divisible by Three & Nine");
            }
            else
            {
                Console.WriteLine("NOT Divisible by Three and Nine");
            }
        }
    }
}
