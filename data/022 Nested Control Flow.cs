using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //Nested Control Flow
            for(int i = 1; i <= 10; i++) //for -> (variable initialization, condition, iteration)
            {
                if (i == 3 || i == 5) Console.WriteLine("Ok, this is number {0}!", i); //find number 3 and 5 in for loop
                else Console.WriteLine(i); //print statement
            }
        }
    }
}
