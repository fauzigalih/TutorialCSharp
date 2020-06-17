using System; //library

namespace TutorialCSharp //namespace
{
    class Program : IPerson //class inheritance interface IPerson
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            IPerson person = new Program();
            person.Human();
        }

        public string Name { get; set; } = "Fauzi Galih";
        public void Human()
        {
            for(int i = 0; i < Name.Length; i++)
            {
                Console.Write("{0} ", Name[i]);
            }
            Console.WriteLine();
        }
    }

    interface IPerson
    {
        string Name { get; set; }
        void Human();
    }
}
