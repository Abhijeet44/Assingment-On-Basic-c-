using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalStatments
{
    class OddorEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int n = int.Parse(Console.ReadLine());

            int x = n % 2;

            switch (x)
            {
                case 0:
                    Console.WriteLine("Number is Even");
                    break;

                default:
                    Console.WriteLine("Number is Odd");
                    break;
            }
        }
    }
}
