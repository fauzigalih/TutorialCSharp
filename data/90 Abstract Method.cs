using System; //library

namespace TutorialCSharp //namespace
{
    class Program : Person //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            // Person person = new Person(); -> this error, class person is abstract
            Program program = new Program();
            program.Print();
            Console.WriteLine(program.Sum(5, 5));
        }
        static int X { get; set; }
        static int Y { get; set; }
        public override void Print()
        {
            Console.WriteLine("This is example abstract method");
        }

        public override int Sum(int x, int y)
        {
            X = x;
            Y = y;
            return X + Y;
        }
    }

    abstract class Person //abstract class
    {
        public abstract void Print(); //abstract method
        public abstract int Sum(int x, int y); //abstract method
    }
}
