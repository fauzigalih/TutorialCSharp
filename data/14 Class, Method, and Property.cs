using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Person person = new Person(); //initialization  class Person
            person.FirstName = "Fauzi"; //set property FirstName in class Person
            person.LastName = "Galih"; //set properti LastName in class Person
            Console.WriteLine(person.FullName); //print fullname with property FullName
            Console.WriteLine(person.GetFullName()); //print fullname with method GetFullName
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

        public string GetFullName() //method -> output: FirstName + LastName
        {
            return FirstName + " " + LastName;
        }
    }
}
