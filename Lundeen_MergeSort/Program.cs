using System;

namespace Lundeen_MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 30, 900, 55, 54, 56, 71, -43, 0, 4529, 555, 639, 101, 102, 100, 5, 82, 50, -77, 14, 99, 104, 1 };
            MergeSort.Sort(array, 0, array.Length - 1);
            PrintArray(array);

        }
        static void PrintArray(int[] array)
        {
            int screenWidth = 4;
            for (int i = 0; i < array.Length; i++)
            {
                screenWidth--;
                if (screenWidth == 0)
                {
                    screenWidth = 4;
                    Console.WriteLine(array[i]);
                }
                else
                {
                    Console.Write(array[i] + ", ");
                }
            }
        }
    }
}
