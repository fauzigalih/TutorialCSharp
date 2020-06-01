using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5 }; //array
            Console.Write("Search number? "); //statement
            int search = Convert.ToInt32(Console.ReadLine()); //user input
            Console.WriteLine("Your search in index-" + Array.IndexOf(numbers, search)); //statement output
        }
    }
}
