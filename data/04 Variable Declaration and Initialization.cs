using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            int x = 5; //declaration and initialization 

            int y; //declaration
            y = 5; //initialization

            int? z = null; //int? is defined is null
            Console.WriteLine(z); //statement null will be print white space
            z = 5; //initialization variable replace null with 5
            Console.WriteLine(z); //statement not null print 5
        }
    }

}
