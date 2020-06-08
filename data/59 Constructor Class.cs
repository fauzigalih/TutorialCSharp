using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            new Program();
        }
        Program() //constructor class
        {
            int x = 5;
            double y = 5.5;
            float z = Convert.ToSingle(x + y); //convert to float
            Console.WriteLine(z);
        }
    }
}
