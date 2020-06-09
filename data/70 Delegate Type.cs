using System; //library

delegate int Sum(int sum); //delegate
namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Sum plus = new Sum(Plus);
            Sum minus = new Sum(Minus);
            Print print = new Print(Hello);
            Console.WriteLine(minus(10));
            print("Hello World!");
            SendHello(print);
        }

        delegate void Print(string print); //delegate
        static int sum = 5;
        
        static int Plus(int plus)
        {
            sum += plus;
            return sum;
        }

        static int Minus(int minus)
        {
            sum -= minus;
            return sum;
        }

        static void Hello(string hello)
        {
            Console.WriteLine("Delegate test: {0}", hello);
        }

        static void SendHello(Print send)
        {
            send("Say Hello!");
        }
    }
}
