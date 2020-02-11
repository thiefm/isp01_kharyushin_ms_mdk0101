using System;

namespace ConsoleApp1
{
    static class ArraySort
    {
        public static void BubbleSort(ref int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            bool isSwap = false;
            while (true)
            {
                isSwap = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        isSwap = true;
                    }
                }
                if (!isSwap)
                    break;
            }
        }
        public static void SelectionSort(ref int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            for (int i = 0; i < array.Length; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[maxIndex] < array[j])
                        maxIndex = j;

                if (maxIndex != i)
                {
                    int tmp = array[i];
                    array[i] = array[maxIndex];
                    array[maxIndex] = tmp;
                }
            }
        }
    }
}
