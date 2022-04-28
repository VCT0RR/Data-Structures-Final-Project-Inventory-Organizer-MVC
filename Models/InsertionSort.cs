using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryOrganizingFinalProject
{
    public class InsertionSort //Insertion Sorting class
    {
        //public void method takes one parameter of data type int and is used to sort the unsorted array using the insertion sort algorithm
        public void InsertionSortAlgorithm(int[] array)
        {
            //takes the length/size of the array
            int arraySize = array.Length;

            //for loop is used to to iterate through the length of the array one at a time for each item
            for (int i = 1; i < arraySize; ++i)
            {
                int key = array[i];
                int j = i - 1;

                //while loop is used to move the items in the array that are greater than the key to one position ahead of its current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }

        //public void method takes one parameter of data type int and is used to print the sorted array
        public void printSortedArray(int[] array)
        {
            //takes the length of the array
            int arraySize = array.Length;

            //for loop is used to print the length of the sorted array
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
