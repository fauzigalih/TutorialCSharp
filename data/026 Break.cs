using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            for(int i = 9; i > 0; i--) //for loop
            {
                for(int j = i; j > 0; j--) //for loop
                {
                    if (j == 3) break; //break is stoped for loop
                    Console.Write(j + " "); //printout
                }
                Console.WriteLine(); //new line
            }
        }
    }
}
