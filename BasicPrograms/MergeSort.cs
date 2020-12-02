using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograms
{
    class MergeSort
    {
        static public void doMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        static public void mergeSortRecursive(int[] numbers, int left, int right)
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
