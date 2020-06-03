using System; //library
using System.Collections.Generic; //new library for list
using System.Linq;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //List
            List<int> numbers1 = new List<int>() { 5, 6, 10, 42, 10, 23, 25 }; //declaration and initilization list
            List<int> numbers2 = new List<int>() { 5, 6, 10, 42, 10, 23, 25 }; //declaration and initilization list
            List<int> numbers3 = numbers1;
            bool equal1 = numbers1.Equals(numbers2); //its false
            bool equal2 = numbers1.Equals(numbers3); //its true because assign with variable numbers1 not initialization list again
            bool squenceEqual = numbers1.SequenceEqual(numbers2); //its true

            if (equal1) Console.WriteLine("its method equal1");
            if (equal2) Console.WriteLine("its method equal2");
            if (squenceEqual) Console.WriteLine("its method squence equal");
        }
    }
}
