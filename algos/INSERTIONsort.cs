using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSERTIONsort
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

            Console.WriteLine("\nApplying insertion sort");

            int key;
        

            for (int j = 1; j < array.Length; j++) 
            {
                key= array[j];
                    int  i = j-1; //setting the boundary of our sorted area in our array
                while(i>=0 && array[i]>key) 
                {                                              
                    array[i + 1] = array[i];
                    i--;
                }
                
                array[i + 1] = key;

                Console.Write("\nAfter " + j +" iteration :" );
                for(int a=0; a<array.Length ; a++) //displaying loop for the elements of sorted array 
                {
                    if (a == j+1)
                        Console.Write(" | ");
                    Console.Write( array[a] + "   ");
                }

            }
            // sorting is done
            Console.WriteLine("\nYour array after applying insetion sort:");
            foreach (int x in array) //displaying loop for the elements of sorted array 
            {
                Console.Write(x + "   ");
            }

            Console.Read();
        }
    }
}
