using System;
using System.Collections;

namespace ShellSort
{
    public class ShellSort
    {
        static void shellSort(int[] arr, int arraySize)
        {
            int i, j, increment, temp;
            increment = 3;

            while (increment > 0)
            {
                for (i = 0; i < arraySize; i++)
                {
                    j = i;
                    temp = arr[i];

                    while ((j >= increment) && (arr[j - increment] > temp))
                    {
                        arr[j] = arr[j - increment];
                        j = j - increment;
                    }

                    arr[j] = temp;
                }
                if (increment / 2 != 0)
                {
                    increment = increment / 2;
                }
                else if (increment == 1)
                {
                    increment = 0;
                }
                else
                {
                    increment = 1;
                }
            }
        }
    }
}