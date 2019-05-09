using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
       static void mergesort(int[] a, int low, int high,int size)
        {
            int mid;
            if (low < high) //this block of code is used for dividing the array in two arrays untill unless it comes to 1 element in array
                //then it will call other merge function to merge two array in order  
            {
                Console.WriteLine();
                 for (int x=low; x<=high; x++)  //displaying loop for the elements of sorted array 
                {
                    Console.Write(a[x] + "   ");
                }
                mid = (low + high) / 2;
                mergesort(a, low, mid, size);
                mergesort(a, mid + 1, high,size);
                merge(a, low, high, mid,size);
            }
            return;
        }


         static  void merge(int[] a, int low, int high, int mid, int size)
            {
                int i, j, k;
                int [] temp = new int [size*2];
                i = low;
                k = low;
                j = mid + 1;
                while (i <= mid && j <= high)
                {
                    if (a[i] < a[j])
                    {
                        temp[k] = a[i];
                        k++;
                        i++;
                    }
                    else
                    {
                        temp[k] = a[j];
                        k++;
                        j++;
                    }
                }
                while (i <= mid)
                {
                    temp[k] = a[i];
                    k++;
                    i++;
                }
                while (j <= high)
                {
                    temp[k] = a[j];
                    k++;
                    j++;
                }
                for (i = low; i < k; i++)
                {
                    a[i] = temp[i];
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

            Console.WriteLine("\nApplying Merge sort");

            mergesort(array,0,size-1,size);


            Console.WriteLine("\nYour array after applying merge sort:");
            foreach (int x in array) //displaying loop for the elements of sorted array 
            {
                Console.Write(x + "   ");
            }


            Console.Read();
        }
    }
}
