using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Console.Write("write ? ");
            _name = Console.ReadLine();
            Console.WriteLine(_name);
        }

        static string _name; //field
        public string Name //property
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
