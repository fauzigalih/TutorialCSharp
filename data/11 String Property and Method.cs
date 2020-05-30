using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            string name = "Fauzi Galih";
            string[] words = name.Split(' '); //make array from string with split method -> method
            name.Trim(); //make string to remove white spaces -> method
            int length = name.Length; //get length form string -> property

            //this a example for method and property string
        }
    }

}
