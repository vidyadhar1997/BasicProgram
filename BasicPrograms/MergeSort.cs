using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class MergeSort
    {
        public static void doMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, leftEnd, numElements, temPos;
            leftEnd = (mid - 1);
            temPos = left;
            numElements = (right - left + 1);

            while ((left <= leftEnd) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[temPos++] = numbers[left++];
                else
                    temp[temPos++] = numbers[mid++];
            }

            while (left <= leftEnd)
                temp[temPos++] = numbers[left++];

            while (mid <= right)
                temp[temPos++] = numbers[mid++];

            for (i = 0; i < numElements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        public static void mergeSortRecursive(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                mergeSortRecursive(numbers, left, mid);
                mergeSortRecursive(numbers, (mid + 1), right);
                doMerge(numbers, left, (mid + 1), right);
            }
        }

        public static void mergeMain()
        {
            Console.WriteLine("enter the array length");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[length];
            Console.WriteLine("enter the array element");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("MergeSort By Recursive Method");
            mergeSortRecursive(numbers, 0, length - 1);
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);
        }
    }
}
