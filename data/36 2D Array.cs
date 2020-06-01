using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //2D Array
            int[,] numbers1 = new int[2, 4] //2 is row, 4 is column
            {
                { 1, 2, 3, 4 },
                { 2, 4, 6, 8 },
            };
            Console.WriteLine("numbers1[1,3] => {0}", numbers1[1, 3]);

            int[,] numbers2 =
            {
                { 1, 2, 3, 4 },
                { 2, 4, 6, 8 },
            };
            Console.WriteLine("numbers2[0,1] => {0}", numbers2[0, 1]);
        }
    }
}
