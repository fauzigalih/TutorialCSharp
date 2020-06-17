using System; //library

namespace TutorialCSharp //namespace
{
    class Program : Person //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Program a = new Program();
            Person b = new Person();
            Person c = new Program();

            Console.WriteLine(a.Sum(2, 3)); //output: 5
            Console.WriteLine(b.Sum(2, 3)); //output: 6
            Console.WriteLine(c.Sum(2, 3)); //output: 5
        }

        //Overriding method from parrent class
        public override int Sum(int x, int y)
        {
            return x + y;
        }
    }

    class Person
    {
        public virtual int Sum(int x, int y)
        {
            return x * y;
        }
    }
}
