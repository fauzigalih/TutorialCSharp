using System; //library

delegate int Sum(int sum); //delegate
namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            object a = 1;
            dynamic b = 2;
            Console.WriteLine("field a : {0} and type is {1}", a, a.GetType());
            Console.WriteLine("field b : {0} and type is {1}", b, b.GetType());
            b += "a";
            Console.WriteLine("field b : {0} and type is {1}", b, b.GetType());
            b = true;
            Console.WriteLine("field b : {0} and type is {1}", b, b.GetType());
            b = 'C';
            Console.WriteLine("field b : {0} and type is {1}", b, b.GetType());
            b = DateTime.Now;
            Console.WriteLine("field b : {0} and type is {1}", b, b.GetType());

            Print(10);
            Print("Hello");
            Print(false);
            Print(3.4);
        }

        static void Print(dynamic dyn)
        {
            Console.WriteLine("Parameter is {0} and type is {1}", dyn, dyn.GetType());
        }
    }
}
