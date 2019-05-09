using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_dim_arrays
{

    class Program
    {

        static void Frequency(string str)
        { 
           Console.WriteLine("String is:: " +str);
             int [] smallAlphabets = new int[26];
             int [] digits = new int[10];
             int []capAlphabets = new int[26];

             int[][] count = new int[3][];
             count[0] = new int[26]; //small alphabets
             count[1] = new int[26]; //capital alphabets
             count[2] = new int[10]; //digits
 
            for (int i = 0; i < str.Length; i++)
             {

                 if (Char.IsDigit(str[i]))
                 {
                     count[2][str[i] - 48]++;
                 }
                 else if (Char.IsUpper(str[i]))
                 {
                     count[1][str[i] - 65]++;
                 }
                 else if (Char.IsLower(str[i]))
                 {
                     count[0][str[i] - 97]++;
                 }
             }
             Console.WriteLine("Alphabets.s...");
             for (int i = 0; i < count.Length; i++)
             {
                 if (i == 0)
                     Console.WriteLine("small alphabets...");
                 else
                     if(i==1)
                         Console.WriteLine("capital alphabets...");
                     else
                         Console.WriteLine("digits...");
                 
                 for (int j = 0; j <count[i].Length; j++)
                 {
                     if (i == 0)
                     {
                         if (count[0][j] != 0)
                             Console.WriteLine(Convert.ToChar(j + 97) + " : " + count[i][j]);
                     }

                     else if (i == 1)
                     {
                         if (count[1][j] != 0)
                             Console.WriteLine(Convert.ToChar(j + 65) + " : " + count[i][j]);

                     }
                     else if (i == 2)
                     {
                         if (count[2][j] != 0)
                             Console.WriteLine(Convert.ToChar(j + 48) + " : " + count[i][j]);
                     }
                     
                     }
                 
             }

        }

        static object[][] ToJaggedArray(int [,] multiarray)
        {

            object [][] jagged = new object[multiarray.GetLength(0)][];
            int col = multiarray.GetLength(1);

            for (int i = 0; i < multiarray.GetLength(0); i++)
            {
                jagged[i] = new object[col];
                for (int k = 0; k <col; k++)
                {
                    jagged[i][k] = multiarray[i, k];
                }
            }

            return jagged;
        }


        static int avgAOA(int[,] array)
        {
          
            int avg = 0;
            int sum = 0;
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sum += array[i,j];
                }
            }
            Console.WriteLine("sum: " +sum);
            avg = sum / array.Length;
            return avg;
        }

        static int Sum2D(int[][] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
            }
            return sum;
        }

        static bool isSymmetric(int[] array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                if (array[i] == array[array.Length - 1 - i])
                    ;
                else
                    return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            #region if array is symmetric
            int size;
            Console.WriteLine("Q1... array for isSymmetic\nEnter Size of array: ");
            size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Elements of Array: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            if (isSymmetric(array))
            {  
            Console.WriteLine("the array is Symmeteric!!!");
            }
            else
                Console.WriteLine("the array is not Symmeteric!!!");

            #endregion


            Console.WriteLine();
            #region sum of integers in jagged array
            int[][] array1 = new int[][]{
                new int[] { 1, 2, 3, 4 }, 
                new int[] { 1, 2, 3, 4 }, 
                new int[] { 1, 2, 3, 4 }
            };
            for (int i = 0; i <array1.Length; i++)
            {
                for (int j = 0; j < array1[i].Length; j++)
                {
                    Console.Write(array1[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(  "The Sum of Jagged array:: " + Sum2D(array1));
            #endregion  
          
            Console.WriteLine();
            #region AVG of matrix array
                int[,] matrixArray = new int[3, 4] { {1,2,3,4},{5,6,7,8},{9,10,11,12} };
                for (int i = 0; i < matrixArray.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixArray.GetLength(1); j++)
                    {
                        Console.Write(matrixArray[i,j] + "\t");
                    }
                    Console.WriteLine();
                }
            Console.WriteLine(  "The Average of Matrix array:: " + avgAOA(matrixArray));


            #endregion

            Console.WriteLine();
            #region convert matrix array to jagged array
            int[,] multiArray = new int[3, 4] { {1,2,3,4},{4,5,6,7},{8,9,10,11} };
            object[][] Convertedjagged = ToJaggedArray(multiArray);
            Console.WriteLine("convertedJagged : ");
            for (int i = 0; i < Convertedjagged.Length; i++)
            {
                for (int j = 0; j < Convertedjagged[i].Length; j++)
                {
                    Console.Write(int.Parse(Convertedjagged[i][j].ToString()) + "\t");
                }
                Console.WriteLine();
            }
            #endregion


            Console.WriteLine();
            string str = "This is just 1 line.";
            Frequency(str);

            Console.ReadKey();
        }
    }
}
