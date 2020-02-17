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
                        Swap(array, i, i + 1);
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
                    Swap(array, i, maxIndex);
            }
        }

        private static void Swap(int[] array, int index, int indexSwap)
        {
            int tmp = array[index];
            array[index] = array[indexSwap];
            array[indexSwap] = tmp;
        }
    }
}
