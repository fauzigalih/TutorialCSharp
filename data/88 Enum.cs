using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            var user = Enum.GetNames(typeof(User));
            string userFind = Enum.GetName(typeof(User), 1);
            Console.WriteLine(userFind);

            Console.WriteLine("\nUser constant names:");
            foreach (string str in user)
                Console.WriteLine(str);
        }

        enum User
        {
            Fauzi,
            Galih,
        }
    }
}
