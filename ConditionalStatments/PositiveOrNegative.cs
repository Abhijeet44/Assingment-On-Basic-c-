using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalStatments
{
    class PositiveOrNegative
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int n = int.Parse(Console.ReadLine());

            if(n > 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }

        }
    }
}
