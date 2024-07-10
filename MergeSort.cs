namespace MergeSortExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Merge Sort";
            var numbers = new[] { 10, 3, 1, 7, 9, 2, 0 };

            Console.WriteLine("Original array:");
            PrintArray(numbers);

            MergeSort(numbers, 0, numbers.Length - 1);

            Console.WriteLine("\nSorted array:");
            PrintArray(numbers);

            Console.ReadKey();
        }

        static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);

                Merge(array, left, mid, right);
            }
        }

        static void Merge(int[] array, int left, int mid, int right)
        {
            int leftSize = mid - left + 1;
            int rightSize = right - mid;

            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            Array.Copy(array, left, leftArray, 0, leftSize);
            Array.Copy(array, mid + 1, rightArray, 0, rightSize);

            int i = 0, j = 0, k = left;
            while (i < leftSize && j < rightSize)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftSize)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < rightSize)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
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
