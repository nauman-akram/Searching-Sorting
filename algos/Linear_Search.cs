using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    class LinearSearch 
    {
        int [] array ;
        int size;
        int key;
      public  LinearSearch(int size)
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

        }


        public int LinearSearchFirstOCC( int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (key == array[i])
                    return i;
            }
            return -1;
        }

        public int LinearSearchLastOCC(int key)
        {
            int lastocc = -1;
           
            for (int i = 0; i < array.Length; i++)
            {
                if (key == array[i])
                    lastocc = i;         
            }
            if (lastocc >= 0)
                return lastocc;

            else
                return -1;
        }

        public int LinearSearchCount(int key)
        {
          
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (key == array[i])
                    count++;
                
            }
            if (count >= 0)
                return count;
            
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

            LinearSearch LSobj = new LinearSearch(size);
            Console.WriteLine("\nEnter your desired number  to Search its FIRST OCCURENCE : ");
            key = int.Parse(Console.ReadLine());
                result = LSobj.LinearSearchFirstOCC(key);
            if (result != -1)
                Console.WriteLine("Your desired element's first occurence found at index " + result + " in given array..");
            else
                Console.WriteLine("Element not found in array");


            Console.WriteLine("Enter your desired number to Search its last OCCURNCE : ");
            key = int.Parse(Console.ReadLine());

            result = LSobj.LinearSearchLastOCC(key);
            if (result != -1)
                Console.WriteLine("Your desired element's last occurence found at index " + result + " in given array..");
            else
                Console.WriteLine("Element not found in array");

            Console.WriteLine("Enter your desired number count to Search its COUNT : ");
            key = int.Parse(Console.ReadLine());
 

             result = LSobj.LinearSearchCount( key);
            if (result != -1)
                Console.WriteLine("Your desired element's total occurrence found are " + result + " in given array..");
            else
                Console.WriteLine("Element not found any occurrence in array");
            

          



            Console.Read();
        }
    }
}
