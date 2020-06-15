using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //Array
            int[] numbers; //creating variable array type integer
            numbers = new int[10]; //set maximum array on variable -> max: 10
            numbers[0] = 5; //assign array index 0 with value 5
            Console.WriteLine(numbers[0]); //output: 5

            string[] chars = new string[] { "Fauzi", "Galih" }; //declaration array with value
            string[] chars2 = { "Fauzi", "Galih" }; //And you can like this, simple
            Console.WriteLine(chars[0]); //output: Fauzi
        }
    }
}
