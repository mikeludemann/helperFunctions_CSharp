using System;
using System.Linq;
public class CountingSort
{
    public static void CountingSort(int[] array)
    {
        int[] sortArray = new int[array.Length];

        int minValue = array[0];
        int maxValue = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue) {
                minValue = array[i];
            }
            else if (array[i] > maxValue) {
                maxValue = array[i];
            }
        }

        int[] counter = new int[maxValue - minValue + 1];

        for (int i = 0; i < array.Length; i++)
        {
            counter[array[i] - minValue]++;
        }

        counter[0]--;

        for (int i = 1; i < counter.Length; i++)
        {
            counter[i] = counter[i] + counter[i - 1];
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            sortArray[counter[array[i] - minValue]--] = array[i];
        }

        Array.ForEach(sortArray, element => Console.Write(element + " "));

    }
}
