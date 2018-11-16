using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PermutationSort
{
    private static void Swap(ref char first, ref char second)
    {
        if (first == second)
        {
            return;
        }

        first ^= second;
        second ^= first;
        first ^= second;
    }

    public static void PermutationSort(char[] list)
    {
        int x = list.Length - 1;
        getPermutation(list, 0, x);
    }

    private static void getPermutation(char[] list, int k, int m)
    {
        if (k == m)
        {
            {
                Console.WriteLine(list);
            }
        }
        else
        {
            for (int i = k; i <= m; i++)
            {
                Swap(ref list[k], ref list[i]);
                GetPer(list, k + 1, m);
                Swap(ref list[k], ref list[i]);
            }
        }
    }
}

