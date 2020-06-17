using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            int? a = 5;
            int? b = null;
            Console.WriteLine(a ??= b); //(not null ?? null) -> not null -> a
            a = null;
            b = 10;
            Console.WriteLine(a ??= b); //b
            // ??= is variable, property, indexer element

            Console.WriteLine("Fauzi" ?? null);
            Console.WriteLine(null ?? "Galih");
        }
    }
}
