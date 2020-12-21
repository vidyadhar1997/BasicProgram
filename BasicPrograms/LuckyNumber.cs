using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class LuckyNumber
    {
        public void luckyNumber()
        {
            Random random = new Random();
            int randonmNumber = random.Next(0, 11);
            Console.WriteLine("Enter the user input");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber < randonmNumber)
            {
                Console.WriteLine("user number is smaller");
            }
            else if (userNumber > randonmNumber)
            {
                Console.WriteLine("user number is grater");
            }
            else
            {
                Console.WriteLine("congratulation user number and random number is equal");
            }
        }
    }
}
