using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //Do While Loop
            int i = 1; //variable integer
            do //do it
            {
                Console.WriteLine(i); //print of variable in loop
                i++; //increment
            }
            while (i <= 10); //condition
        }
    }
}
