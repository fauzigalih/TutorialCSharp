using System; //library

namespace TutorialCSharp //namespace
{
    class Program : Person //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Program program = new Program();
            program.Name = "Fauzi Galih";

            Console.WriteLine(program.ToString());
            Console.WriteLine(program);
        }
    }

    class Person
    {
        protected string Name { get; set; }
        public override string ToString() //override to parrent class method ToString
        {
            return Name;
        }
    }
}
