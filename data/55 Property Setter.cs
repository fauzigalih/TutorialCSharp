using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Program program = new Program();
            Console.Write("Your First Name ? ");
            program.FirstName = Console.ReadLine(); //difference of getter
            Console.Write("Your Last Name ? ");
            program.LastName = Console.ReadLine(); //difference of getter
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

        private string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value; //setter
            }
        }

        private string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value; //setter
            }
        }
    }
}
