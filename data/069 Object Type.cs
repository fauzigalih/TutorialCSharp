using System; //library
using System.Collections.Generic;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            object x = "Fauzi";
            object y = "Galih";
            //is error -> object z = x + y; or string z = x + y;
            string z = (string)x + y; //its work

            object a = 1;
            int b = 2;
            //is error -> int c = a + b;
            int c = (int)a + (int)b; //its work

            int number = 123;
            object objNumber = number; //its work
            string name = "Fauzi Galih";
            object objName = name; //its work

            List<object> numbers = new List<object>();
            for(int i = 0; i <= 5; i++)
            {
                numbers.Add(i);
            }
            int sum = 0;
            for(int j = 0; j < numbers.Count; j++)
            {
                sum += (int)numbers[j];
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
