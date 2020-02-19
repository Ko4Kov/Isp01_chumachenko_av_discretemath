using System;

namespace sorted
{
    static class Sort
    {
        public static void Swap(int[] array, int index, int swap)
        {
            int tmp = array[index];
            array[index] = array[swap];
            array[swap] = tmp;
        }
        public static void BubbleSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;

            bool swapDetected = false;
            while (true)
            {
                swapDetected = false;
                for (int index = 0; index < array.Length - 1; index++)
                {
                    if (array[index] < array[index + 1])
                    {
                        Swap(array, index, index + 1);
                        swapDetected = true;
                    }
                }
                if (!swapDetected) break;
            }
        }
        public static void SelectionSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;
            for (int index = 0; index < array.Length; index++)
            {
                int minIndex = index;
                for (int next = index + 1; next < array.Length; next++)
                    if (array[minIndex] < array[next])
                        minIndex = next;
                if (minIndex != index)
                    Swap(array, minIndex, index);
            }
        }
    }  
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка пузырьком:");
            int[] array = new int[5] { 2, 5, 3, 8, 11 };
            Sort.BubbleSort(array);
            foreach (int elem in array)
                Console.Write(elem + " ");

            Console.WriteLine();

            Console.WriteLine("Сортировка выбором:");
            Sort.SelectionSort(array);
            foreach (int element in array)
                Console.Write(element + " ");
        }
    }
}

