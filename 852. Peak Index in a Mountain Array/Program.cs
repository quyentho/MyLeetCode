using System;
using System.Linq;

namespace _852._Peak_Index_in_a_Mountain_Array
{
    //https://leetcode.com/problems/peak-index-in-a-mountain-array/
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 24, 69, 100, 99, 79, 78, 67, 36, 26, 19 };

            Console.WriteLine(PeakIndexInMountainArray2(arr));
        }

        public static int PeakIndexInMountainArray(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return i;
                }
            }

            return -1;
        }

        public static int PeakIndexInMountainArray2(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            int mid = (left + right) / 2;
            while (left < right)
            {
                if (arr[mid] < arr[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }

                mid = (left + right) / 2;
            }

            return mid;
        }
    }
}
