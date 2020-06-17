using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            string run = Run(5); //call method Run() with assign argument 5
            Console.Write(run);
        }

        private static string Run(int times) //method Run() with parameter times
        {
            string message = "";
            for(int i = 0; i < times; i++) //for loop
            {
                message += "Index " + i + "\n";
            }
            return message; //return -> point of the method
        }
    }
}
