using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };  //this should take 80 bytes of memory all in the row

            //Traversal
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            int[] newArr = new int[11];
            //I want to insert let's say 9000 as 5th element
            int insertIndex = 4; //0 based indexing
            int insertValue = 9000;
            for (int i = 0; i < insertIndex; i++)
                newArr[i] = arr[i];
            newArr[insertIndex] = insertValue;

            for (int i = insertIndex + 1; i < newArr.Length; i++)
                newArr[i] = arr[i - 1]; //our index sizes changed
            Console.WriteLine(string.Join(",", newArr));

            Console.WriteLine(arr[4]); //this is O(1) //very quick operation

            //Search is O(n) on average
            int foundIndex = -1;
            int needle = 7;
            newArr[3] = needle; //Update is O(1)
            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] == needle)
                {
                    foundIndex = i;
                    Console.WriteLine($"Found {needle} at index {foundIndex}");

                    break; //we are good 
                }
            }
            //how much memory will 1Billion integers will take?
            //check the int default type
            int arrSize = 1_000_000_000;
            Console.WriteLine($"Size of integer is {sizeof(int)}");
            int[] bigArr = Enumerable.Range(0, arrSize).ToArray();
            Console.WriteLine(bigArr[555555]);
            Console.WriteLine($"Press enter to end program after creating Array of size {arrSize}");
            Console.ReadLine();
        }
    }
}
