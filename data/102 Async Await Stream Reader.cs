using System; //library
using System.IO;
using System.Threading.Tasks;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Task<int> task = RunAsync();

            Console.WriteLine("Please wait patiently while I do something important.");

            string line = Console.ReadLine();
            Console.WriteLine("You entered (asynchronous logic): " + line);

            task.Wait();
            var x = task.Result;
            Console.WriteLine("Count: " + x);

            Console.WriteLine("[DONE]");
            Console.ReadLine();
        }

        static async Task<int> RunAsync()
        {
            string file = @"C:\Users\Fauzi Galih\Downloads\Video\cek.txt";
            Console.WriteLine("File is reading..");
            int count = 0;
            using (StreamReader reader = new StreamReader(file))
            {
                string str = await reader.ReadToEndAsync();
                count += str.Length;
                
            }
            Console.WriteLine("Reading file is finish..");
            return count;
        }
    }
}
