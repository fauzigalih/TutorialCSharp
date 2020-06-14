using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Print(5); //call a method with assign value 5
        }

        public static void Print(int a) //static method with parameter int a -> Print(5) -> a = 5
        {
            int x = a + 5; //declaration and initialization variable x with sum parameter + 5
            Console.WriteLine(x); //print statement variable x
        }
    }
}
