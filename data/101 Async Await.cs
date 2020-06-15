using System; //library
using System.Threading.Tasks;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Program program = new Program();
            program.Run();
        }

        async Task Run()
        {
            Task<int> task = Print(5);
            Program program = new Program();
            program.Print("Fauzi");
            int count = await task;
            program.Count(count);
        }

        async Task<int> Print(int number)
        {
            int count = 0;
            await Task.Run(() =>
            {
                for(int i = 0; i < number; i++)
                {
                    Console.WriteLine($"Async Task no-{i + 1}");
                    count += 1;
                }
            });
            return count;
        }

        void Print(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"Void {name[i]}");
            }
        }

        void Count(int count)
        {
            Console.WriteLine("Number of count is " + count);
        }
    }
}
