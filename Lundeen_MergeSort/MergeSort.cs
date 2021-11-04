using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lundeen_MergeSort
{
    class MergeSort
    {
        public static void merge(int[] array, int left, int middle, int right)
        {
            int loopTime = middle;
            loopTime++;
            // +1 to account for offset
           for (int i = 0; i < loopTime; i++)
            {
                int temp;
                // if right 'subarray' is larger, then swap
                if(array[i] < array[middle + 1])
                {
                    temp = array[i];
                    array[i] = array[middle + 1];
                    array[middle + 1] = temp;

                    // sort right hand side, since it's already sorted, we can stop at the first value smaller than this one
                    //flops values until value on right is less than current value
                    for (int j = middle; j < right; j++)
                    {
                        if(array[j] < array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j+1];
                            array[j] = temp;
                        }
                    }
                }
            }
        }
       public static void Sort(int[] array, int left, int right)
        { // Largest to Smallest
            if (right - left > 0)
            {
                int middle = (((right - 1) + left) / 2);
                Sort(array, left, middle);
                Sort(array, middle + 1, right);
                merge(array, left, middle, right);
            }
            return;
        }
    }
}
