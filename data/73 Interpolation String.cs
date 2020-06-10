using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            int x = 5;
            Console.WriteLine("Value of x is {0} type {1}", x, x.GetType());
            Console.WriteLine($"Value of x is {x} type {x.GetType()}"); //Interpolation String

            dynamic y = true;
            Console.WriteLine($"Value of y is {y} type {y.GetType()}");
            y = "Hello";
            Console.WriteLine($"Value of y is {y} type {y.GetType()}");
            y = 20;
            Console.WriteLine($"Value of y is {y} type {y.GetType()}");
        }
    }
}
