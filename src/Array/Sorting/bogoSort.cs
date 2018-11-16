using System;
using System.Collections.Generic;

namespace BogoSort
{
    public class BogoSort
    {
        static void BogoSort(List<int> list, bool announce, int delay)
        {
            int iteration = 0;
            while (!IsSorted(list))
            {
                if (announce)
                {
                    printSteps(list, iteration);
                }
                if (delay != 0)
                {
                    System.Threading.Thread.Sleep(Math.Abs(delay));
                }
                list = Remap(list);
                iteration++;
            }

            printSteps(list, iteration);
        }

        static void printSteps(List<int> list, int iteration)
        {
            Console.Write("Bogosort: {0}: ", iteration);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        static bool IsSorted(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        static List<int> Remap(List<int> list)
        {
            int temp;
            List<int> newList = new List<int>();
            Random r = new Random();

            while (list.Count > 0)
            {
                temp = (int)r.Next(list.Count);
                newList.Add(list[temp]);
                list.RemoveAt(temp);
            }
            return newList;
        }
    }
}
