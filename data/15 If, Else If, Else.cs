using System; //library
using System.Linq;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Person person = new Person(); //initialization  class Person
            person.FirstName = "Fauzi"; //set property FirstName in class Person
            person.LastName = "Galih"; //set property LastName in class Person

            Console.Write("Guess what my name is? "); //statement a question
            string checkName = Console.ReadLine().ToLower(); //your answer

            if (person.FullName.ToLower() == checkName) //if fullname is your answer
            {
                Console.WriteLine("Yes, its true!"); //if its true, print this statement
            }else if (person.FirstName.ToLower() == checkName || person.LastName.ToLower() == checkName) //if fullname is firstname or lastname
            {
                Console.WriteLine("Hmm.. You get 1/2 of the fullname!"); //if its true, print this statement
            }
            else //if condition undefined
            {
                Console.WriteLine("Ah, you wrong..!"); //print this statement
            }
        }
    }

    class Person //new class
    {
        public string FirstName { get; set; } //property with getter and setter
        public string LastName { get; set; } //property with getter and setter
        public string FullName //property with getter -> output: FirstName + LastName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
