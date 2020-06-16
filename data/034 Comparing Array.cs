using System; //library
using System.Linq;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            int[] numbers1 = { 2, 10, 5, 20, 3 }; //array
            int[] numbers2 = { 2, 10, 5, 20, 3 }; //array
            int[] numbers3 = numbers1;

            //you can't condition in below
            if (numbers1 == numbers2) Console.WriteLine("this match");
            else Console.WriteLine("not match"); //this output

            //you can condition in below with assign from variable array
            if (numbers1 == numbers3) Console.WriteLine("this work, and match");
            else Console.WriteLine("not work, not match");

            //or you can with defferent array
            if (Enumerable.SequenceEqual(numbers1, numbers2)) Console.WriteLine("yes, match again");
            else Console.WriteLine("not, match again");
        }
    }
}
