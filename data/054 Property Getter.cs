using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Program program = new Program();
            Console.Write("Your First Name ? ");
            program.firstName = Console.ReadLine();
            Console.Write("Your Last Name ? ");
            program.lastName = Console.ReadLine();
            Console.WriteLine("Your username is : " + program.FullName + "\n\nThank You..");
        }

        private string firstName;
        private string lastName;

        private string FullName
        {
            get
            {
                return (firstName + lastName).ToLower(); //getter
            }
        }
    }
}
