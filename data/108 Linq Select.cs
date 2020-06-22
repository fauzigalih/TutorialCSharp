using System; //library
using System.Linq;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            QueryStringArray();
        }

        static void QueryStringArray()
        {
            string[] names =
            {
                "Fauzi", "Galih", "John", "Siwer","Keleb", "Odon", "Kepet"
            };

            var nameStat = from name in names
                           select name; //select
            foreach(var name in nameStat)
            {
                Console.WriteLine(name);
            }
        }
    }
}
