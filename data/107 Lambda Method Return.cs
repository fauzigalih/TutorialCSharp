using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            int a = Sum(5, 6);
            double b = Sum(5.44, 6);
            float c = Sum(5, 6.55f);
            string d = Sum("Fauzi", "Galih");
            dynamic e = Sum("Fauzi", 62.44f);
            Console.WriteLine($"{a} \n{b} \n{c} \n{d} \n{e}");

            bool f = Check(34);
            Console.WriteLine(f);

            string g = FullName("Fauzi", "Galih");
            Console.WriteLine(g);
        }

        static dynamic Sum(dynamic x, dynamic y) => x + y;

        static bool Check(dynamic check) => check > 0 && check <= 100;

        static string FullName(string first, string last) => first + " " + last;
    }
}
