using System;
using System.Collections.Generic;
using System.Text;

namespace Myfirstproject.ConditionalStatments
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter \n1 : Addition \n2 : Substraction \n3 : Multiplication\n4 : Division");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1st Number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number : ");
            int b = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Result : " + (a+b));
                    break;

                case 2:
                    Console.WriteLine("Result : " + (a-b));
                    break;

                case 3:
                    Console.WriteLine("Result : " + a*b);
                    break;

                case 4:
                    Console.WriteLine("Result : " + (a/b));
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
