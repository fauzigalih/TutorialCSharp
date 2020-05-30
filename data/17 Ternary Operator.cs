using System; //library
using System.Linq;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //Ternary Operator
            //condition ? true : false -> (1 < 3) ? "Yes" : "No"
            bool test = true;
            bool checkTest = test ? true : false;
            Console.WriteLine(checkTest);

            int number = 5;
            string checkNumber = (number <= 5) ? "Yes" : "No";
            Console.WriteLine(checkNumber);

            int[] numbers = { 1, 2, 3 };
            int checkNumbers = (numbers.Length < 1) ? 0 : numbers.Sum();
            Console.WriteLine(checkNumbers);

            string[] names = { "Fauzi", "Galih" };
            string name = string.Join(" ", names);
            string fullName = names[0] + " " + names[1] == name ? $"Yes, its me. Im {name}." : "Hmm.. its not me.";
            Console.WriteLine(fullName);
        }
    }
}
