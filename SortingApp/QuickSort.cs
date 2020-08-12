using System;
using System.Collections.Generic;
using System.Text;

namespace SortingApp
{
    public static class QuickSort
    {

        public static string QuickSortString(char[] items)
        {
            return QuickSortText(items, 0, items.Length - 1);
        }

        // A recursive version of Quicksort for characters.       
        public static string QuickSortText(char[] items, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(items, start, end);
                QuickSortText(items, start, pivot - 1);
                QuickSortText(items, pivot + 1, end);
            }
            return new string(items);
        }

        public static int Partition(char[] iInput, int start, int end)
        {
            int pivot = iInput[end];
            int pIndex = start;

            for (int i = start; i < end; i++)
            {
                if (iInput[i] <= pivot)
                {
                    char temp = iInput[i];
                    iInput[i] = iInput[pIndex];
                    iInput[pIndex] = temp;
                    pIndex++;
                }
            }
            char anotherTemp = iInput[pIndex];
            iInput[pIndex] = iInput[end];
            iInput[end] = anotherTemp;
            return pIndex;
        }
    }
}

