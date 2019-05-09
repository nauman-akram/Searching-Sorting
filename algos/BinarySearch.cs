using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearchClass
    {
        int[] array;
        int size;
        int key;
        public BinarySearchClass(int size)
        {
            this.size = size;
            array = new int[size];
            Random rndm = new Random();
            Console.Write("YOUR ARRAY IS ::\n");
            for (int i = 0; i < size; i++)
            {
                array[i] = rndm.Next(100);
                Console.Write(array[i] + "  ");
            }
            Array.Sort(array);
            Console.Write("\nYOUR ARRAY AFTER Arrangement ::\n");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + "  ");
            }


        }


        public int BSFirstOCC(int key)
        {
            int low = 0;
            int high = array.Length - 1;
            int mid = -1;
            while(low <= high)
            {
                mid = (low + high )/2;

                if (array[mid] > key)
                    high = mid - 1;
                else if (array[mid] < key)
                    low = mid + 1;
                else if(array[mid] == key)
                    return mid;
            }

            return -1;
        }

        public int BSLastOCC(int key)
        {
           int lastocc = -1;
            int low = 0;
           
            int high = array.Length - 1;
            int mid = -1;
            while (low <= high)
            {
                mid = (low + high) / 2;

                if (array[mid] > key)
                    high = mid - 1;
                else if (array[mid] < key)
                    low = mid + 1;
                else if (array[mid] == key)
                {  for (int x = mid; x < array.Length - 1; x++)
                    {
                        if (array[x] == key)
                            lastocc = x;
                        else
                            x = array.Length;
                    }
                return lastocc;
                }
            }

            if (lastocc > -1)
                return lastocc;
            else

            return -1;
        }

        public int BSCount(int key)
        {
            int firstocc = BSFirstOCC(key);
            int lastocc = BSLastOCC(key);

            if (lastocc >= 0 && firstocc >= 0)
            {
                return lastocc - firstocc + 1;
            }
            else
                return -1;
        }

    };





    class Program
    {

        static void Main(string[] args)
        {

            int size;
            Console.WriteLine("Enter size of your array");
            size = int.Parse(Console.ReadLine());
            int key;
            int result;

            BinarySearchClass BSobj = new BinarySearchClass(size);
           
            Console.WriteLine("\nEnter your desired number  to Search its FIRST OCCURRENCE : ");
            key = int.Parse(Console.ReadLine());
            result = BSobj.BSFirstOCC(key);
            if (result != -1)
                Console.WriteLine("Your desired element's first occurrence found at index " + result + " in given array..");
            else
                Console.WriteLine("Element not found in array");


            Console.WriteLine("Enter your desired number to Search its last OCCURRNCE : ");
            key = int.Parse(Console.ReadLine());
            result = BSobj.BSLastOCC(key);
            if (result != -1)
                Console.WriteLine("Your desired element's last occurrence found at index " + result + " in given array..");
            else
                Console.WriteLine("Element not found in array");

            Console.WriteLine("Enter your desired number count to Search its COUNT : ");
            key = int.Parse(Console.ReadLine());
            result = BSobj.BSCount(key);
            if (result != -1)
                Console.WriteLine("Your desired element's total occurrence found are " + result + " in given array..");
            else
                Console.WriteLine("Element not found in array");






            Console.Read();
        }
    }
}
