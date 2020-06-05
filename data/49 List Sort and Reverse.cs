using System; //library
using System.Collections.Generic; //new library for list
using System.Linq; //new library for sort and reverse

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //List
            List<int> numbers = new List<int> { 2, 10, 3, 1 };
            numbers.Sort(); 
            numbers.Reverse();
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
