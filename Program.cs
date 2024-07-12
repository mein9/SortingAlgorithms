namespace SortingAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 90, 3, 2, 56, 32, 34, 65, 68, 76, 1, 0, 100, 8 };
            int[] arr2 = { 90, 3, 2, 56, 32, 34, 65, 68, 76, 1, 0, 100, 8 };

            PrintArray(arr1);
            BubbleSort(arr1);
            PrintArray(arr1);

            PrintArray(arr2);
            SelectionSort(arr2);
            PrintArray(arr2);
        }
        public static void PrintArray(int[] arr) 
        {
            foreach(int i in arr) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static int BubbleSort(int[] arrToSort) //good if low on system memory 
        {
            int totalOuterIterations = 0;
            int temp;
            // Overall O(n^2) runtime
            // Big Omega - O(n^2)

            for (int i = 0; i < arrToSort.Length; i++) //how many times through unsorted elements O(n)
            {
                ++totalOuterIterations;
                int swaps = 0;
                for (int j = 0; j < arrToSort.Length - 1 - i; j++) //O(n)
                {
                    //swap places if j is greater than j + 1
                    if (arrToSort[j] > arrToSort[j + 1]) //change to < to reverse array
                    {
                        swaps++;
                        temp = arrToSort[j];
                        arrToSort[j] = arrToSort[j + 1];
                        arrToSort[j + 1] = temp;
                    }
                }
                if (swaps == 0) break;
            }
           return totalOuterIterations;
        }

        public static void SelectionSort(int[] arrToSort)
        {
            // minIndex keeps track of smallest index in each iteration
            // temp stores the value being swapped
            int minIndex, temp;

            for (int i = 0; i < arrToSort.Length - 1; i++) // iterate through unsorted elements O(n)
            {
                minIndex = i; // set minIndex to current index

                for (int j = i + 1; j < arrToSort.Length; j++) // iterate through the remaining elements O(n)
                {
                    // update minIndex if the current element is smaller than the element at minIndex
                    if (arrToSort[j] < arrToSort[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // swap the elements if minIndex is not the current index
                if (minIndex != i)
                {
                    temp = arrToSort[i];
                    arrToSort[i] = arrToSort[minIndex];
                    arrToSort[minIndex] = temp;
                }
            }
        }
    }
    }

