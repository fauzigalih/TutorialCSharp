using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Console.Write("How many you want array? "); //statement question
            int size = Convert.ToInt32(Console.In.ReadLine()); //size : convert integer on user input
            int[] numbers = new int[size]; //declaration array with maximum value in size
            for(int i = 0; i < numbers.Length; i++) //for loop condition
            {
                Console.Write($"Array no-{i+1} : "); //statement question to assign array
                numbers[i] = Convert.ToInt32(Console.In.ReadLine()); //assign value to array
            }
            Console.Write("Your array is : "); //statement
            for(int j = 0; j < numbers.Length; j++) //for loop condition
            {
                Console.Write(numbers[j] + " "); //output result of array
            }
            Console.WriteLine(); //new line
        }
    }
}
