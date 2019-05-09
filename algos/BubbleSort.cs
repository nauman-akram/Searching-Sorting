using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
     
    class Program
    {

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

            Console.WriteLine("\nApplying bubble sort");

            for (int i = 0; i < array.Length -1; i++) //first loop of iteration that defines after n iternation n elements (max,second max third ....) will be bubble out to set at the end of array
            {
                for (int j = 0; j < array.Length - i - 1; j++) //second loop that deal with the checking and swapping of two adjacent element at a time
                {                                              // after its full loop iterations max will be set at the last index 
                    if (array[j] > array[j+1])      // checking if the first index is greater than the its next one, if yes it will swap them
                    {
                        int temp = array[j];        //for swaping the first element is stored in a temp variable that will allow us to store the next one at this index of j
                        array[j] = array[j+1];      // next index's value is placed at j position, now j+1 position is free
                        array[j+1] = temp;           // we can place the temp value to the recent freed sapce that is j+1
                    }
                }
            }
             // sorting is done
            Console.WriteLine("Your array after applying bubble sort:");
            foreach (int x in array) //displaying loop for the elements of sorted array 
            {
                Console.Write(x + "   ");
            }

            Console.Read();
        }
    }
}
