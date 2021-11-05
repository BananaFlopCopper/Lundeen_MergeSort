using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lundeen_MergeSort
{
    class MergeSort
    {
        public static void Merge(int[] array, int left, int middle, int right)
        {
            
            // +1 to account for offset
           for (int i = left; i <= middle; i++)
            {
                int temp;
                // if right 'subarray' is larger, then swap
                if(array[i] < array[middle + 1])
                {
                    //flip
                    temp = array[i];
                    array[i] = array[middle + 1];
                    array[middle + 1] = temp;

                    // sort right hand side, since it's already sorted, we can stop at the first value smaller than this one
                    //flops values until value on right is less than current value
                    for (int j = middle+1; j < right; j++)
                    {
                        if(array[j] < array[j + 1])
                        {
                            //flip
                            temp = array[j];
                            array[j] = array[j+1];
                            array[j+1] = temp;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
       public static void Sort(int[] array, int left, int right)
        { // Largest to Smallest
            if (right - left > 0)
            {
                int middle = ((right + left) / 2);
                Sort(array, left, middle);
                Sort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
            return;
        }
    }
}
