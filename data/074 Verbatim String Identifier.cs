using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            string[] @for = { "Fauzi", "Galih" }; //add @ for identifier as variable, if only 'for' is error
            for (int i = 0; i < @for.Length; i++)
            {
                Console.WriteLine($"Your name is {@for[i]}!");
            }

            string file1 = @"c:\documents\files\u0066.txt";
            string file2 = "c:\\documents\\files\\u0066.txt";
            Console.WriteLine(file1);
            Console.WriteLine(file2);

            string str1 = "Hello, \"Please say \u0048ello\x0021\"";
            string str2 = @"Hello, ""Please say \u0048ello\x0021""";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
