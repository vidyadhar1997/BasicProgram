using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class AddtionOfTwoNumber
    {
        public static void addtionOfTwoNumber()
        {
            Console.WriteLine("Enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int result = number1 + number2;
            Console.WriteLine("Addtion of two number is " + result.ToString());
            Console.ReadLine();
        }
    }
}
