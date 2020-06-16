using System; //library
using System.Collections.Generic; //new library for list

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //List
            List<int> numbers1 = new List<int>(); //creating varibale list with data type integer
            numbers1.Add(5); //add value 5 in numbers1[0]
            numbers1.Add(6); //add value 6 in numbers1[1]
            Console.WriteLine("numbers1[0] : {0} \nnumbers1[1] : {1}", numbers1[0], numbers1[1]); //print statement

            List<int> numbers2 = new List<int>() { 7, 8 }; //declaration and initilization list
            Console.WriteLine("numbers2[0] : {0} \nnumbers2[1] : {1}", numbers2[0], numbers2[1]); //print statement
        }
    }
}
