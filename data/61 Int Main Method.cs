using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static int Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            new Program(5, 5.5); //assign argument x=5 and y=5.5
            return 1; //return type number -> 0,1,2,3...
        }
        Program(int x, double y) //constructor class with parameter: x, y
        {
            float z = Convert.ToSingle(x + y); //convert to float
            Console.WriteLine(z);
        }
    }
}
