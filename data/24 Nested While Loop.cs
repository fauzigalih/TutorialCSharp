using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //Nested For Loop
            int num = 10;
            int i = 0;
            while(i <= num){
                int j = 0;
                while(j <= i)
                {
                    Console.Write(" * ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
