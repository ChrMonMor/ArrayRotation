using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how much would you like the array to be rotated");

            //-- hardcoded array to make this easier to make the logic
            string[] hardCodeArray = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            //-- Shows the array in console
            PrintArray(hardCodeArray);

            int rotatedBy = Convert.ToInt32(Console.ReadLine());

            //-- shows the rotated array
            PrintArray(ArrayToTheRight(hardCodeArray, rotatedBy));
            Console.ReadLine();
        }
        public static string[] ArrayToTheRight(string[] array, int rotatedBy)
        {
            //-- Make cope of the array
            string[] arrayCopy = new string[array.Length];

            //-- looping as many times as wanting to rotate.
            for (int i = 1; i <= rotatedBy; i++)
            {
                //-- puts array's index+1 into the copy's current index.
                for (int j = 0; j < array.Length; j++)
                {
                    //-- if it is the last one, put it in index 0.
                    if (array.Length - 1 == j)
                    {
                        arrayCopy[arrayCopy.Length - 1] = array[0];
                    }
                    else
                    {
                        arrayCopy[j] = array[j + 1];
                    }
                }
                //-- makes the original array into a copy of the copy after one rotation
                Array.Copy(arrayCopy, 0, array, 0, array.Length);
            }
            return array;
        }
        //-- logic for printing the array in the console
        public static void PrintArray(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
