using System; //library
using System.Collections.Generic; //new library for list

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //List
            List<int> numbers = new List<int>() { 5, 6, 10, 42, 10, 23, 25 }; //declaration and initilization list
            int count = numbers.Count; //property count 
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
