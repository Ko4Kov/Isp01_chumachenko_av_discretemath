using System;

namespace zada4ki_mojno_men9t_
{
    static class Sort
    {
        public static void BubbleSort(int[] array)
        {
            if (array == null || array.Length < 2)
                return;
            bool swapDetected = false;
            for (int index = 0; index < array.Length; index++)
            {
                swapDetected = false;
                for (int j = index + 1; j < array.Length; j++)
                {
                    if (array[index] < array[j])
                    {
                        int tmp = array[index];
                        array[index] = array[j];
                        array[j] = tmp;
                        swapDetected = true;
                    }
                }
                if (!swapDetected) break;
            }
        }
        public static void SelectionSort(int[] massiv)
        {
            if (massiv == null || massiv.Length < 2)
                return;
            for (int index = 0; index < massiv.Length; index++)
            {
                int minIndex = index;
                for (int next = index + 1; next < massiv.Length; next++)
                {
                    if (massiv[minIndex] < massiv[next])
                        minIndex = next;
                    if (minIndex != index)
                    {
                        int tmp = massiv[index];
                        massiv[index] = massiv[minIndex];
                        massiv[minIndex] = tmp;
                    }
                }
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
            int[] massiv = new int[5] { 2, 5, 3, 8, 11 };
            Sort.SelectionSort(massiv);
            foreach (int element in massiv)
                Console.Write(element + " ");
        }
    }
}
