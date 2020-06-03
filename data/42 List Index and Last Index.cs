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
            int index = numbers.IndexOf(10); //fisrt find -> output : 2
            int notIndex = numbers.IndexOf(11); //if not index -> output : -1
            int lastIndex = numbers.LastIndexOf(10); //last find -> output : 4
            Console.WriteLine(index);
            Console.WriteLine(notIndex);
            Console.WriteLine(lastIndex);
        }
    }
}
