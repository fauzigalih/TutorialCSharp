using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Program program = new Program();
            Console.Write("Your First Name ? ");
            program.FirstName = Console.ReadLine();
            Console.Write("Your Last Name ? ");
            program.LastName = Console.ReadLine();
            Console.WriteLine("Your username is : " + program.FullName + "\n\nThank You..");
        }

        private string FullName
        {
            get
            {
                return (FirstName + LastName).ToLower(); //getter
            }
        }

        private string FirstName { get; set; } //custom getter and setter property

        private string LastName { get; set; } //custom getter and setter property
    }
}
