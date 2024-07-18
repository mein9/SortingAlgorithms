using System.Diagnostics;

namespace SortingAlgorithms
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 90, 3, 2, 56, 32, 34, 65, 68, 76, 1, 0, 100, 8 };
            int[] arr2 = { 90, 3, 2, 56, 32, 34, 65, 68, 76, 1, 0, 100, 8 };
            int[] arr3 = { 90, 3, 2, 56, 32, 34, 65, 68, 76, 1, 0, 100, 8 };
            int[] arr4 = { 90, 3, 2, 56, 32, 34, 65, 68, 76, 1, 0, 100, 8 };

            MergeSort(arr4);
            PrintArray(arr4);

            //Console.WriteLine("Bubblesort");
            //PrintArray(arr1);
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //BubbleSort(arr1);
            //stopwatch.Stop();
            //PrintArray(arr1);
            //Console.WriteLine("Elapsed time for Bubblesort: " + stopwatch.Elapsed);
            //Console.WriteLine();


            //Console.WriteLine("SelectionSort");
            //PrintArray(arr2);
            //stopwatch.Restart();
            //SelectionSort(arr2);
            //stopwatch.Stop();
            //PrintArray(arr2);
            //Console.WriteLine("Elapsed time for SelectionSort: " + stopwatch.Elapsed);
            //Console.WriteLine();

            //Console.WriteLine("InsertionSort");
            //PrintArray(arr3);
            //stopwatch.Restart();
            //InsertionSort(arr3);
            //stopwatch.Stop();
            //PrintArray(arr3);
            //Console.WriteLine("Elapsed time for InsertionSort: " + stopwatch.Elapsed);
            //Console.WriteLine();

            //Console.WriteLine("Please select a sorting Algorithm:");
            //Console.WriteLine("1: Bubble Sort");
            //Console.WriteLine("2: Selection Sort");
            //Console.WriteLine("3: Insertion Sort");

            string? userSelection = Console.ReadLine();

            Student student1 = new Student("Matt", 3.8);
            Student student2 = new Student("Rich", 2.6);
            Student student3 = new Student("Adam", 3.2);

            Student[] students = { student1, student2, student3 };

            switch (userSelection)
            {
                case "1":
                    // bubble Sort
                    BubbleSort(students);
                    PrintArray(students);
                    break;
                case "2":
                    // selection sort
                    
                    break;
                case "3":
                    // insertion sort
                    
                    break;
                default:
                    // none match 
                    break;
                    
            }

        }
        public static void PrintArray(Student[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($" {item.name} : {item.gpa} ");
            }
            Console.WriteLine();
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static int BubbleSort(Student[] arrToSort) //Sorts array of Students 
        {
            int totalOuterIterations = 0;
            Student temp;
            // Overall O(n^2) runtime
            // Big Omega - O(n^2)

            for (int i = 0; i < arrToSort.Length; i++) //how many times through unsorted elements O(n)
            {
                ++totalOuterIterations;
                int swaps = 0;
                for (int j = 0; j < arrToSort.Length - 1 - i; j++) //O(n)
                {
                    //swap places if j is greater than j + 1
                    if (arrToSort[j].gpa < arrToSort[j + 1].gpa) //change to < to reverse array
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
    
        public static void InsertionSort(int[] arrToSort) 
        {

            for (int i = 1; i < arrToSort.Length; i++)
            {
                int temp = arrToSort[i];  // store element as it might be overwritten
                int priorIndex = i - 1;  //start comparing with element before the current element

                // if prior element is greater than stored element
                // and we have not reached the end of the array
                while (priorIndex >= 0 && arrToSort[priorIndex] > temp)
                {
                    arrToSort[priorIndex+1] = arrToSort[priorIndex];
                    priorIndex--;
                }

                arrToSort[priorIndex+1] = temp; // sets prior index to saved variable
            }
        }
    
        public static void MergeSort(int[] arrToSort) // Splits array up and merges together, recursive
        {
            if (arrToSort.Length <= 1) return; //example of an early return

            int mid = arrToSort.Length / 2;
            int[] leftSubArray = new int[mid];
            int[] rightSubArray = new int[arrToSort.Length - mid];

            for (int i = 0; i < mid; i++) 
            {
                leftSubArray[i] = arrToSort[i];
            }
            for (int i = mid; i < arrToSort.Length; i++)
            {
                rightSubArray[i - mid] = arrToSort[i];
            }

            MergeSort(leftSubArray);
            MergeSort(rightSubArray);


        }
    }
}

