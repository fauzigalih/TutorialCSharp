using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Console.WriteLine("Default value of field: {0}\nDefault value of property: {1}\nDefault value of method: {2}",
                x, Y, Z());
        }
        static int x = 5; //default value of field
        static double Y { get; set; } = 5.5; //default value of property
        static int Z(int z = -5) //default value of method
        {
            return z; 
        }
    }
}
