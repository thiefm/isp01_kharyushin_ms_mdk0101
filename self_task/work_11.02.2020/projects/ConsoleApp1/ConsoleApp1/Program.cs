using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array01 = { 5, 1, 3, 10, 20, 4, 16 };
            int[] array02 = { 5, 1, 3, 10, 20, 4, 16 };

            ArraySort.BubbleSort(ref array01);
            foreach (int elem in array01)
                Console.Write(elem + " ");

            Console.WriteLine();

            ArraySort.SelectionSort(ref array02);
            foreach (int elem in array02)
                Console.Write(elem + " ");

            Console.ReadKey();
        }
    }
}
