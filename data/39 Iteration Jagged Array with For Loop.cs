using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //Jagged Array
            int[][] numbers =
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 2, 4, 6, 8 },
                new int[] { 2, 4, 6, 8, 10, 12 },
                new int[] { 2, 4 }
            };
            Console.WriteLine("You have array of numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write(numbers[i][j] + " ");
                }
                Console.WriteLine();
            }

            //numbers.Length; output: 4 (total all array -> new int[])
            //numbers[0].Length; output: 4 [1 2 3 4] (total row index 0 of array)
        }
    }
}
