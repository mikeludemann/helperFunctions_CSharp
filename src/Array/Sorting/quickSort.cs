using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Quicksort
{
    public static void quickSort(ref int[] array)
    {
        sort(0, array.Length - 1, ref array);
    }
    private static void sort(int left, int right, ref int[] array)
    {
        if (left < right)
        {
            int counter = divisor(left, right, ref array);
            sort(left, counter - 1, ref array);
            sort(counter + 1, right, ref array);
        }
    }
    private static int divisor(int left, int right, ref int[] array)
    {
        int i = left;
        
        int j = right - 1;
        int position = array[right];

        do
        {
            while (array[i] <= position && i < right)
                {
                    i += 1;
                }

            while (array[j] >= position && j > left)
                {
                    j -= 1;
                }

            if (i < j)
            {
                int z = array[i];

                array[i] = array[j];
                
                array[j] = z;
            }

        } while (i < j);
        
        if (array[i] > position)
        {
            int z = array[i];
            
            array[i] = array[right];
            
            array[right] = z;
        }
        return i;
    }
}