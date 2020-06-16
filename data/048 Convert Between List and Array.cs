using System; //library
using System.Collections.Generic; //new library for list
using System.Linq;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //List
            List<string> names1 = new List<string>() { "Fauzi", "Galih" };
            List<List<int>> numbers1 = new List<List<int>>()
            {
                new List<int> { 2, 4, 6 },
                new List<int> { 1, 3, 5 },
                new List<int> { 2, 3, 5, 7, 9 }
            };

            //Array
            string[] names2 = new string[2] {"Fauzi", "Galih"};
            int[][] numbers2 =
            {
                new int[] { 2, 4, 6 },
                new int[] { 1, 3, 5 },
                new int[] { 2, 3, 5, 7, 9 }
            };

            //List to Array
            string[] name1 = names1.ToArray();
            int[] number1 = numbers1[0].ToArray();

            //Array to List
            List<string> name2 = names2.ToList();
            List<int> number2 = numbers2[0].ToList();
        }
    }
}
