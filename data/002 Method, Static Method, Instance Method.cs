using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Console.WriteLine("Hello World!"); //a statement

            IsStatic(); //can call this method without initialization of class Program, this is same with (Program.IsStatic();)

            Program myProgram = new Program(); //initialization class of Program -> step 1
            myProgram.NotStatic(); //call method with initialization of class Program -> step 2
        }

        public void NotStatic() //only method
        {
            Console.WriteLine("This is only method!"); //statement
        }

        public static void IsStatic() //static method
        {
            Console.WriteLine("This is static method!"); //statement
        }
    }
}

