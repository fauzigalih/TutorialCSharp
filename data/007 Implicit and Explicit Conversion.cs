using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //Implicit Conversion -> description below
            // if the data type to be converted has a smaller size or range of values ​​than the result of the converted data type.
            int a = 5; //32 bit integer
            long b = a; //64 bit integer

            //Explicit Conversion -> description below
            //If the two conditions where conversion is implicitly possible are not met, then we must use conversion explicitly. This explicit conversion is usually called casting.
            double c = 5.5; //8 byte
            int d = (int)c; //4 byte
        }
    }
}
