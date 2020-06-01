using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            int[] numbers1 = { 2, 10, 5, 20, 3 }; //array
            int[] numbers2 = { 2, 10, 5, 20, 3 }; //array
            Array.Sort(numbers1); //method sort a-z for array
            Array.Reverse(numbers2); //method reverse from back to front for array

            Console.Write("Numbers1 sort: ");
            for(int i = 0; i < numbers1.Length; i++)
            {
                Console.Write(numbers1[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Numbers2 reverse: ");
            for(int j = 0; j < numbers2.Length; j++)
            {
                Console.Write(numbers2[j] + " ");
            }
            Console.WriteLine();

            Array.Reverse(numbers1);
            Console.Write("Numbers1 sort and reverse: ");
            for (int k = 0; k < numbers1.Length; k++)
            {
                Console.Write(numbers1[k] + " ");
            }
            Console.WriteLine();
        }
    }
}
