using System; //library
using System.Collections;

namespace TutorialCSharp //namespace
{
    class Program //class
    {
        static void Main(string[] args) //method special, automatic run program on this Main method and call a statement
        {
            Push("Welcome");
            Push(1);
            Push(2);
            Push(3);
            Push(true);
            Push(null);
            Push(3.5f);
            StackList();

            Pop();
            Pop();
            Pop();
            StackList();

            Clear();
            StackList();
        }

        static Stack stack = new Stack(); //Stack

        static void Push(dynamic push) //Push is Add value in last to stack
        {
            stack.Push(push);
        }

        static void Pop() //Pop is Remove value in last to stack
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
