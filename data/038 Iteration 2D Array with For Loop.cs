using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //2D Array
            int[,] numbers = 
            {
                { 1, 2, 3, 4 },
                { 2, 4, 6, 8 },
            };
            Console.WriteLine("You have array of numbers:");
            for(int i = 0; i < numbers.GetLength(0); i++)
            {
                for(int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }

            //numbers.Length; output: 8 (total all array -> is value)
            //numbers.GetLength(0); output: 4 [1 2 3 4] (total row index 0 of array)
        }
    }
}
