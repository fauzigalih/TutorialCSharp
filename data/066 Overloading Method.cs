using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Program program = new Program();
            Console.WriteLine(program.Sum(5, 4));
            Console.WriteLine(program.Sum(5, 4.3));
        }

        //Overloading
        int Sum(int x, int y)
        {
            return x + y;
        }

        double Sum(double x, double y)
        {
            return x * y;
        }
    }
}
