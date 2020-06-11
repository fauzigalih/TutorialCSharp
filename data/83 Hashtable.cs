using System; //library
using System.Collections;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Hashtable hashtable = new Hashtable()
            {
                    { "Me", "Fauzi" },
                    { 2, "Galih" },
                    { 3, true },
                    { false, "Four" },
                    { "Fv", 5.5 },
                    { 8.5F, 8.5 }
            };

            Console.WriteLine(hashtable["Me"]);
            Console.WriteLine(hashtable[2]);
            Console.WriteLine(hashtable[8.5F]);
            Console.WriteLine();

            hashtable.Add(3000, "Test");
            Console.WriteLine(hashtable[3000]);
            Console.WriteLine();

            foreach (DictionaryEntry hash in hashtable)
            {
                Console.WriteLine($"Key : {hash.Key}, Value : {hash.Value}, Type Key : {hash.Key.GetType()}, Type Value : {hash.Value.GetType()}");
            }   
        }
    }
}
