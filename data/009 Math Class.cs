using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            double x = -5.5; //variable
            double y = 64; //variable

            Math.Max(x, y); //method can be used to find the highest value of x and y
            Math.Min(x, y); //method can be used to find the lowest value of of x and y
            Math.Sqrt(y); //method returns the square root of x
            Math.Abs(x); //method returns the absolute (positive) value of x
            Math.Round(x); //rounds a number to the nearest whole number

            //You can check other Math class in link : https://docs.microsoft.com/en-us/dotnet/api/system.math?view=netcore-3.1
        }
    }
}
