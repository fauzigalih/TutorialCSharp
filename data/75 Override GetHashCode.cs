using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Program program = new Program();
            program.Name = "Fauzi Galih";
            Console.WriteLine(program.GetHashCode());
        }

        string Name { get; set; }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
