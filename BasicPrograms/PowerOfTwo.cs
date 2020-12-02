using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class PowerOfTwo
    {
        public static void powerOfTwo()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            double powerOfNumber = Math.Pow(number, 2);
            Console.WriteLine("power of number is" + powerOfNumber);
            Console.ReadLine();
        }
    }
}
