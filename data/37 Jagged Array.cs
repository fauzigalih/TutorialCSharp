using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //Jagged Array
            int[][] numbers1 =
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 2, 4, 6, 8 }
            };
            Console.WriteLine("numbers1[1][3] => {0}", numbers1[1][3]);

            int[][] numbers2 =
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 2, 4, 6, 8 },
                new int[] { 2, 4, 6, 8, 10, 12 },
                new int[] { 2, 4 }
            };
            Console.WriteLine("numbers2[2][5] => {0}", numbers2[2][5]);
        }
    }
}
