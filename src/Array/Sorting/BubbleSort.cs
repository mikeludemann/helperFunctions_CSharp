using System;

public class BubbleSort
{
    public enum Direction
    {
        Ascending = 0,
        Descending
    }

    public static void BubbleSort(int[] input, Direction direction = Direction.Descending)
    {
        bool swap;
        var length = input.Length;

        do
        {
            swap = false;

            for (var i = 0; i < length - 1; i++)
            {

                var switchSwap = direction == Direction.Ascending ? input[i] > input[i + 1] : input[i] < input[i + 1];

                if (switchSwap)
                {
                    var temp = input[i];
                    input[i] = input[i + 1];
                    input[i + 1] = temp;
                    swap = true;
                }

            }

        } while (swap);

        Array.ForEach(input, element => Console.Write(element + " "));

    }

}