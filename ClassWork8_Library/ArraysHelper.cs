using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork8_Library
{
    public class ArraysHelper
    {
        public static int Max(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("No max element in empty array!");
            }
            int max = array[0];
            foreach (var item in array)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static int GetSumOfElementsWithOddIndexes(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Invalid array!");
            }
            int sum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += array[i];
                }
            }

            return sum;
        }

        public static void Reverse(int[] array)
        {
            if(array == null)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[array.Length - 1 - i]);
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
