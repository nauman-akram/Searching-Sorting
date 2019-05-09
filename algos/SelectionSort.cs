using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void selectionSort(int[] arr, int n)
        {
            
            int pos_min, temp;//pos_min is used to determine the min value element's index from unsorted area

            for (int i = 0; i < n - 1; i++) //every iteration of this loop will get one element set at its position
            {
                pos_min = i;//set pos_min to the current index of array

                for (int j = i + 1; j < n; j++)
                {
                    //this loop is for selecting the min element from the unsorted area of area
                    //then it will be set at the end of sorted area
                    if (arr[j] < arr[pos_min])
                        pos_min = j;
                    //pos_min will keep track of the index that min
                }

                //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                if (pos_min != i)
                {     //in here we are concerend with the swapping of the min element and element after the last sort that is current iteration of loop
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
                Console.WriteLine();
               for(int a=0; a<arr.Length ; a++) //displaying loop for the elements of sorted array 
                {
                    if (a == i+1)
                        Console.Write(" | ");
                    Console.Write( arr[a] + "   ");
                }

            }

            }
        
        static void Main(string[] args)
        {

            int[] array; //array 
            int size; // size of array that will be given at runtime

            Console.WriteLine("Enter the Size of Array : ");
            size = int.Parse(Console.ReadLine()); // getting input for size of array and converting into integer
            array = new int[size]; // declaration of size of array dynamically
            Console.WriteLine("Your given array is initialized randomly and is: \n");
            Random rndm = new Random(); // for random number genrator for array elements built-in library funtion
            for (int i = 0; i < size; i++)
            {
                array[i] = rndm.Next(100); // assigning random number betweeb=n 0-100
                Console.Write(array[i] + "   "); //displaying on screen
            }

            Console.WriteLine("\nApplying insertion sort");

            selectionSort(array, size);


            Console.WriteLine("\nYour array after applying insetion sort:");
            foreach (int x in array) //displaying loop for the elements of sorted array 
            {
                Console.Write(x + "   ");
            }


            Console.Read();
        }
    }
}
