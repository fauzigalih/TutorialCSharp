using System; //library

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            //Precision is the main difference
            float flt = 1F / 3; //7 digits (32 bit)
            double dbl = 1D / 3; //15-16 digits (64 bit)
            decimal dcm = 1M / 3; //28-29 significant digits (128 bit)
            Console.WriteLine("float: {0} double: {1} decimal: {2}", flt, dbl, dcm);

            /* float and double are floating binary point types. In other words, they represent a number like this:
             * 10001.10010110011
             * The binary number and the location of the binary point are both encoded within the value.
             * 
             * decimal is a floating decimal point type. In other words, they represent a number like this:
             * 12345.65789
             * Again, the number and the location of the decimal point are both encoded within the value – 
             * that's what makes decimal still a floating point type instead of a fixed point type.
             */
        }
    }

}
