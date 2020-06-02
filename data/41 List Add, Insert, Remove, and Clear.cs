using System; //library
using System.Collections.Generic; //new library for list

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //List
            List<int> numbers = new List<int>() { 5, 6 }; //declaration and initilization list -> [5, 6]
            numbers.Clear(); //clear list -> []
            numbers.Add(7); //add 7 to last of list -> [7]
            numbers.Add(8); //add 8 to last of list -> [7, 8]
            numbers.Insert(1, 3); //insert with indexes 1 -> [7, 3, 8]
            numbers.Remove(7); //remove item 7 in list -> [3, 8]
            Console.WriteLine("numbers[0] : {0} \nnumbers[1] : {1}", numbers[0], numbers[1]); //print statement
        }
    }
}
