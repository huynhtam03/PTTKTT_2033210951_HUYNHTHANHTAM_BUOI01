namespace QuickSortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Quick Sort";
            var numbers = new[] { 10, 3, 1, 7, 9, 2, 0 };

            Console.WriteLine("Original array:");
            PrintArray(numbers);

            QuickSort(numbers, 0, numbers.Length - 1);

            Console.WriteLine("\nSorted array:");
            PrintArray(numbers);

            Console.ReadKey();
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;

                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }

        static void PrintArray(int[] array)
        {
            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
