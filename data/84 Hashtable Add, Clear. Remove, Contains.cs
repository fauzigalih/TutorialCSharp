using System; //library
using System.Collections;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Console.WriteLine("First data Hashtable : ");
            HashList();

            hashtable.Clear(); //clear all or delete all data
            Console.WriteLine("After Clear data Hashtable : ");
            HashList();
            
            hashtable.Add(1, "Hello"); //Add
            hashtable.Add(2, "Word");
            Console.WriteLine("After Add data Hashtable : ");
            HashList();

            hashtable.Remove(1); //Remove
            Console.WriteLine("After Remove data Hashtable : ");
            HashList();

            bool search =  hashtable.Contains(2); //Contains
            if (search) Console.WriteLine("Key 2 Found");
            hashtable.ContainsKey(2); //True
            hashtable.ContainsValue("Word"); //true
        }

        static Hashtable hashtable = new Hashtable()
        {
            { "Me", "Fauzi" },
            { 2, "Galih" },
        };

        static void HashList()
        {
            foreach (DictionaryEntry hash in hashtable)
            {
                Console.WriteLine($"Key : {hash.Key}, Value : {hash.Value}");
            }
        }
    }
}
