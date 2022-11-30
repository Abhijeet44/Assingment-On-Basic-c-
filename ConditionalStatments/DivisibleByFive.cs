using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalStatments
{
    class DivisibleByFive
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int n = int.Parse(Console.ReadLine());

            if(n % 5 == 0)
            {
                Console.WriteLine("Number is DIVISIBLE by five");
            }
            else
            {
                Console.WriteLine("Not Divisible by Five");
            }
        }
    }
}
