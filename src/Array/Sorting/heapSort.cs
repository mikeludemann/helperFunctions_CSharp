using System;

namespace heapSort
{
    public class heapSort
    {
        private static void heapSort<T>(T[] array) where T : IComparable<T>
        {
            int heapSize = array.Length;

            buildMaxHeap(array);

            for (int i = heapSize - 1; i >= 1; i--)
            {
                swap(array, i, 0);
                heapSize--;
                sink(array, heapSize, 0);
            }
        }

        private static void buildMaxHeap<T>(T[] array) where T : IComparable<T>
        {
            int heapSize = array.Length;

            for (int i = (heapSize / 2) - 1; i >= 0; i--)
            {
                sink(array, heapSize, i);
            }
        }

        private static void sink<T>(T[] array, int heapSize, int toSinkPos) where T : IComparable<T>
        {
            if (getPositionLeft(toSinkPos) >= heapSize)
            {
                return;
            }


            int largestChildPosition;
            bool isLeftLargest;

            if (getPositionRight(toSinkPos) >= heapSize || array[getPositionRight(toSinkPos)].CompareTo(array[getPositionLeft(toSinkPos)]) < 0)
            {
                largestChildPosition = getPositionLeft(toSinkPos);
                isLeftLargest = true;
            }
            else
            {
                largestChildPosition = getPositionRight(toSinkPos);
                isLeftLargest = false;
            }



            if (array[largestChildPosition].CompareTo(array[toSinkPos]) > 0)
            {
                swap(array, toSinkPos, largestChildPosition);

                if (isLeftLargest)
                {
                    sink(array, heapSize, getPositionLeft(toSinkPos));

                }
                else
                {
                    sink(array, heapSize, getPositionRight(toSinkPos));
                }
            }

        }

        private static void swap<T>(T[] array, int firstPosition, int secondPosition)
        {
            T temp = array[firstPosition];
            array[firstPosition] = array[secondPosition];
            array[secondPosition] = temp;
        }

        private static int getPositionLeft(int parentPostion)
        {
            return (2 * (parentPostion + 1)) - 1;
        }

        private static int getPositionRight(int parentPostion)
        {
            return 2 * (parentPostion + 1);
        }

        private static void getArray<T>(T[] array)
        {

            foreach (T t in array)
            {
                Console.Write(' ' + t.ToString() + ' ');
            }

        }
    }

}
