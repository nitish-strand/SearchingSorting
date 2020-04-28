using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string DataType = "";

            //1. Get the main Data type choice
            bool test = true;
            while (test)
            {
                Console.WriteLine("<---------Welcome to Searching & Sorting within Array Data Structure--------->");
                Console.WriteLine("Enter the Datatype of you interest ");
                Console.WriteLine("Int ");
                Console.WriteLine("Float ");
                Console.WriteLine("Double ");
                Console.WriteLine("String ");
                Console.WriteLine("Co-ordinate ");
                Console.Write("Enter one of the above options(as it is) : ");
                DataType = Console.ReadLine();
                if (DataType == "Int" || DataType == "Float" || DataType == "Double" || DataType == "String" || DataType == "Co-ordinate")
                    test = false;
                else
                    Console.WriteLine("You have entered the wrong choice. Please try again.");
            }

            //2. Size of the Array
            Console.Write("Enter the size of your array: ");
            int ArraySize = Int32.Parse(Console.ReadLine());

            // if co-ordinate operation
            if (DataType == "Co-ordinate")
            {
                List<CoOrdinate> coordinates = new List<CoOrdinate>();

                for (int i=0; i< ArraySize; i++)
                {
                    Console.WriteLine("Enter X : ");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Y : ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    CoOrdinate obj = new CoOrdinate(x, y);
                    coordinates.Add(obj);
                }
                Console.WriteLine("Sorting co-ordinate in preference of X: ");
                coordinates.Sort();
                PrintCoOrdinates(coordinates);
                

                Console.WriteLine("Sorting co-ordinate in preference of Y: ");
                CoOrdinateComparer ccObj = new CoOrdinateComparer();
                coordinates.Sort(ccObj);
                PrintCoOrdinates(coordinates);

                Console.ReadKey();
                return;
            }
            
            else
            {
                //Array declaration 
                Object[] InputArray = new Object[ArraySize];

                // Array filling
                InputArray = FillArray(ArraySize, DataType);

                // Searching or Sorting
                Console.WriteLine("Now what would you like to do ?");
                Console.WriteLine("A. Searching ");
                Console.WriteLine("B. Sorting ");
                string operationType = Console.ReadLine();

                if (operationType == "A")
                {
                    Console.WriteLine("What kind of search? ");
                    Console.WriteLine("1. Linear Search ");
                    Console.WriteLine("2. Binary Search");
                    string searchCh = Console.ReadLine();

                    Console.WriteLine("Enter the element to be searched ");
                    string element = Console.ReadLine();
                    int result = -1;

                    SearchingClass obj = new SearchingClass(InputArray, element, DataType);

                    switch (searchCh)
                    {
                        case ("1"):
                            result = obj.LinearSearch();
                            break;
                        case ("2"):
                            result = obj.BinarySearch();
                            break;
                    }

                    if (result == -1)
                        Console.WriteLine("Element not present");
                    else
                        Console.WriteLine("Element found at " + "index " + result);
                }
                else if (operationType == "B")
                {
                    Object[] SortedArray = new object[ArraySize];

                    Console.WriteLine("What kind of sorting would you like to do? ");
                    Console.WriteLine("1. Bubble Sort ");
                    Console.WriteLine("2. Quick Sort ");
                    Console.WriteLine("3. Merge Sort ");
                    string searchCh = Console.ReadLine();

                    if (searchCh == "1")
                    {
                        MyBubbleSort BSobj = new MyBubbleSort(InputArray, DataType);
                        SortedArray = BSobj.MyArray;
                    }
                    else if (searchCh == "2")
                    {
                        MyOuickSort QSobj = new MyOuickSort(InputArray, 0, ArraySize - 1, DataType);
                        SortedArray = QSobj.MyArray;
                    }
                    else if (searchCh == "3")
                    {
                        MyMergeSort MSobj = new MyMergeSort(InputArray, DataType, ArraySize);
                        SortedArray = MSobj.MyArray;
                    }
                    PrintSortedArray(InputArray, SortedArray, DataType);
                }

                Console.ReadKey();
            }
            
        }
        
        static void PrintCoOrdinates(List<CoOrdinate> coordinates)
        {
            foreach (CoOrdinate cordinate in coordinates)
            {
                Console.WriteLine(cordinate.X + ", " + cordinate.Y);
            }
            Console.WriteLine();
        }

        static object[] FillArray(int size, string DataType)
        {
            object[] arr = new object[size];

            Console.Write("Input {0} elements of same datatype:\n", size);
            for (int i = 0; i < size; i++)
            {
                if(DataType == "Int")
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                else if(DataType == "Float")
                    arr[i] = Convert.ToDecimal(Console.ReadLine());
                else if (DataType == "Double")
                    arr[i] = Convert.ToDouble(Console.ReadLine());
                else if(DataType == "String")
                    arr[i] = Console.ReadLine();
            }
            return arr;
        }

        static void PrintSortedArray(object[] unsorted, object[] sorted, string DataType)
        {
            int i;

            Console.Write("Initial array is: ");
            for (i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }
            
            Console.Write("\nSorted Array is: ");
            for (i = 0; i < sorted.Length; i++)
            {
                Console.Write(sorted[i] + " ");
            }

            Console.Write("\nSorted Array w.r.t. input index is: ");
            for (i = 0; i < sorted.Length; i++)
            {
                SearchingClass obj = new SearchingClass(unsorted, sorted[i], DataType);
                Console.Write( obj.LinearSearch() + " ");
            }
        }

    }
}
