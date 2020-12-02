using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press 1 for userName,press 2 for addtionOfTwoNumber,press 3 for leapYear,press 4 for powerOfTwo");
            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    UserName.username();
                    break;
                case 2:
                    AddtionOfTwoNumber.addtionOfTwoNumber();
                    break;
                case 3:
                    LeapYear.leapYear();
                    break;
                case 4:
                    PowerOfTwo.powerOfTwo();
                    break;
                default:
                    break;
            }

        }
    }
    }
}
