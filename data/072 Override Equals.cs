using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Person person = new Person();
            person.FirstName = "Fauzi";
            person.LastName = "Galih";
            Person name = new Person();
            name.FirstName = "Fauzi";
            name.LastName = "Galih";

            Console.WriteLine(person.Equals(person));
            Console.WriteLine(person.Equals(name));
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public override bool Equals(object obj) //override Equals
        {
            if(FullName == ((Person)obj).FullName)
            {
                return true;
            }
            return false;
        }
    }
}
