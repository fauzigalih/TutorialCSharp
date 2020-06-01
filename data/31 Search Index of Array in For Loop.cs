using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5 }; //array
            bool found = false;
            Console.Write("Search number? "); //statement
            int search = Convert.ToInt32(Console.ReadLine()); //user input
            for(int i = 0; i < numbers.Length; i++) //for loop condition
            {
                if(numbers[i] == search) //logic if index numbers value = user input
                {
                    found = true; //bool true
                    Console.WriteLine("Yeah, you found number {0} in index-{1}", search, numbers[i]); //statement if logic true
                    break; //stoped loop
                }
            }
            if (!found) Console.WriteLine("Oh, your number not found.."); //statement if not found
        }
    }
}
