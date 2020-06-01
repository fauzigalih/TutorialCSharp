using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            int[] numbers = { 2, 10, 5, 20, 3 }; //array
            Array.Sort(numbers); //method sort for array
            for(int i = 0; i < numbers.Length; i++) //for loop condition
            {
                Console.WriteLine(numbers[i]); //statement of array after sort
            }
        }
    }
}
