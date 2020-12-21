using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press 1 for userName,press 2 for addtionOfTwoNumber,press 3 for leap year,4 for power of two,5 for lucky number,6 for merged sort");
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
                case 5:
                    LuckyNumber luckyNumber = new LuckyNumber();
                    luckyNumber.luckyNumber();
                    break;
                case 6:
                    MergeSort.mergeMain();
                    break;
                default:
                    break;
            }
        }
    }
}