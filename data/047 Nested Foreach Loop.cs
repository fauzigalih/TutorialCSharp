using System; //library
using System.Collections.Generic; //new library for list

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //List
            List<List<int>> numbers1 = new List<List<int>>()
            {
                new List<int> { 2, 4, 6 },
                new List<int> { 1, 3, 5 },
                new List<int> { 2, 3, 5, 7, 9 }
            };

            int[][] numbers2 =
            {
                new int[] { 2, 4, 6 },
                new int[] { 1, 3, 5 },
                new int[] { 2, 3, 5, 7, 9 }
            };

            Console.WriteLine("This foreach of List :");
            foreach(List<int> number1 in numbers1) //foreacch list, you can to be array with numbers1.ToArray()
            {
                foreach(int number in number1)
                {
                    Console.Write(number + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("This foreach of Array :");
            foreach (int[] number2 in numbers2)
            {
                foreach(int number in number2)
                {
                    Console.Write(number + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
