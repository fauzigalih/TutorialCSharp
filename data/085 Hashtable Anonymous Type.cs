using System; //library
using System.Collections;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            HashList();
            HashListVar();
        }

        static Hashtable hashtable = new Hashtable()
        {
            { "Me", "Fauzi" },
            { 2, "Galih" },
        };

        static void HashList()
        {
            Console.WriteLine("Condition with foreach Dictionary type :");
            foreach (DictionaryEntry hash in hashtable)
            {
                Console.WriteLine($"Key : {hash.Key}, Value : {hash.Value}");
            }
        }

        static void HashListVar()
        {
            Console.WriteLine("\nCondition with foreach anonymous type :"); //Anonymous type -> var
            foreach(var hash in hashtable.Keys)
            {
                Console.WriteLine($"Key : {hash}, Value : {hashtable[hash]}");
            }
        }
    }
}
