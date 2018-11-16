using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsertionSort
{
    class InsertionSort
    {
        static int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
        public static void getArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
        }

        public static int[] InsertionSortByShift(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int j;
                var insertionValue = array[i];

                for (j = i; j > 0; j--)
                {
                    if (array[j - 1] > insertionValue)
                    {
                        array[j] = array[j - 1];
                    }
                }

                array[j] = insertionValue;

            }

            return array;
        }

    }
    
}
