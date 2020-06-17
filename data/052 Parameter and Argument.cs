using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Run(5); //call method Run() with assign argument 5
        }

        private static void Run(int times) //method Run() with parameter times
        {
            for(int i = 0; i < times; i++) //for loop
            {
                Output(times * (i + 1));
            }
        }

        private static void Output(int times) //method Output() with parameter times
        {
            Console.WriteLine(times);
        }
    }
}
