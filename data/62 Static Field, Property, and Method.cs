using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Program program = new Program();

            //static field
            program.x += 5; //non static -> must initialization class of program -> output: 10
            y += 5; //is static -> not need initialization class of program -> output: 15

            //static property
            program.X += 5; //output: 5
            Y += 5; //output: 5

            //static method
            program.MyName(); //output: Fauzi Galih
            MyAge(); //output: 23
        }

        //static field
        int x = 5;
        static int y = 10; //is static

        //static property
        int X { get; set; }
        static int Y { get; set; } //is static

        //static method
        string MyName()
        {
            return "Fauzi Galih";
        }

        static int MyAge() //is static
        {
            return 23;
        }
    }
}
