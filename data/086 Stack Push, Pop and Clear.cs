using System; //library
using System.Collections;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Add("Welcome");
            Add(1);
            Add(2);
            Add(3);
            Add(true);
            Add(null);
            Add(3.5f);
            StackList();

            Remove();
            Remove();
            Remove();
            StackList();

            Clear();
            StackList();
        }

        static Stack stack = new Stack(); //Stack

        static void Add(dynamic add) //Push is Add value in last to stack
        {
            stack.Push(add);
        }

        static void Remove() //Pop is Remove value in last to stack
        {
            stack.Pop();
        }

        static void Clear() //Clear All value to stack
        {
            stack.Clear();
        }

        static void StackList()
        {
            Console.WriteLine("This list your stack : ");
            foreach(var st in stack)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine();
        }
    }
}
