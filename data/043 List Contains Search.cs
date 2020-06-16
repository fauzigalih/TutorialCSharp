using System; //library
using System.Collections.Generic; //new library for list

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //List
            List<int> numbers = new List<int>() { 5, 6, 10, 42, 10, 23, 25 }; //declaration and initilization list 
            Console.Write("Search number? ");
            int key = Convert.ToInt32(Console.ReadLine());
            bool search = numbers.Contains(key); //true or false 

            if (search) Console.WriteLine("Yeah, you found number {0}", key);
            else Console.WriteLine("Not found your number");
        }
    }
}
