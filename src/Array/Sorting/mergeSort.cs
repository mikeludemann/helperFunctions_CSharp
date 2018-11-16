using System;
using System.Collections.Generic;
using System.Text;

public class Mergesort
{
	public static void mergeSort(ref int[] array)
	{
		if (array.Length > 1) {

			int middle = Convert.ToInt32(array.Length / 2);

			int[] left = new int[middle];
			for (int i = 0; i <= left.Length - 1; i++) {
				left[i] = array[i];
			}

			int[] right = new int[array.Length - middle];
			for (int i = middle; i <= array.Length - 1; i++) {
				right[i - middle] = array[i];
			}

			sort(ref left);
			sort(ref right);

			array = merge(ref left, ref right);
		}
	}

	private static int[] merge(ref int[] left, ref int[] right)
	{
		int[] newArray = new int[left.Length + right.Length];
		int leftIndex = 0;
		int rightIndex = 0;
		int resultIndex = 0;

		while (leftIndex < left.Length && rightIndex < right.Length) {
			if (left[leftIndex] < right[rightIndex]) {
				newArray[resultIndex] = left[leftIndex];
				leftIndex += 1;
			} else {
				newArray[resultIndex] = right[rightIndex];
				rightIndex += 1;
			}
			resultIndex += 1;
		}

		while (leftIndex < left.Length) {
			newArray[resultIndex] = left[leftIndex];
			leftIndex += 1;
			resultIndex += 1;
		}

		while (rightIndex < right.Length) {
			newArray[resultIndex] = right[rightIndex];
			rightIndex += 1;
			resultIndex += 1;
		}

		return newArray;
	}
}