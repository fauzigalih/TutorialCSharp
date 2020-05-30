using System; //library

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

            switch (checkName)
            {
                case "fauzi galih": //if your answer is this case
                    Console.WriteLine("Yes, its true!"); //print this statement
                    break;
                case "fauzi": //if your answer is this case
                case "galih": //or this case
                    Console.WriteLine("Hmm.. You get 1/2 of the fullname!"); //print this statement
                    break;
                default: //if your answer undifined all case
                    Console.WriteLine("Ah, you wrong..!"); //print this statement
                    break;
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
