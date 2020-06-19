using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            const int number = 23;
            const string name = "Fauzi";

            // name += "Galih"; -> can't run this, because const type
            Console.WriteLine($"My name is {name} and my age {number}");
            Console.WriteLine(Program.fullName);
            Console.WriteLine(FullName);
            GetFullName();
        }

        private const string fullName = "Fauzi Galih";
        public static string FullName { get { return fullName; } }
        public static void GetFullName()
        {
            Console.WriteLine(FullName);
        }
    }
}
