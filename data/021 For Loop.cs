using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //For Loop
            for(int i = 1; i <= 10; i++) //for -> (variable initialization, condition, iteration)
            {
                Console.WriteLine(i); //print statement
            }

            string name = "Fauzi Galih"; //variable initialization
            for (int i = 0; i < name.Length; i++) //for condition
            {
                Console.Write("{0} ", name[i]); //print statement
            }
            Console.WriteLine(); //new line

            string str = "Fauzi103Galih839"; //variable initialization random
            for (int i = 0; i < str.Length; i++) //for condition
            {
                if (Char.IsDigit(str[i])) Console.WriteLine("{0} is the number.", str[i]); //logic if else 1 line
                else Console.WriteLine("{0} is the character.", str[i]);
            }
        }
    }
}
