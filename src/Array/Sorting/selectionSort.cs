using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SelectionSort
{
    static void SelectionSort(ref List<int> array)
    {
        for (int i = 0; i < array.Count; i++)
        {
            int min = i;

            for (int j = i + 1; j < array.Count; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }

            int tmp = array[min];
            array[min] = array[i];
            array[i] = tmp;
        }
    }
}