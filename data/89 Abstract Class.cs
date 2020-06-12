using System; //library

namespace TutorialCSharp //namespace
{
    class Program : Person //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            // Person person = new Person(); -> this error, class person is abstract
        }
    }

    abstract class Person //abstract class
    {

    }
}
