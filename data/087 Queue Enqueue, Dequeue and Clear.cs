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
            QueueList();

            Remove();
            Remove();
            Remove();
            QueueList();

            Clear();
            QueueList();
        }

        static Queue queue = new Queue(); //Queue

        static void Add(dynamic add) //Enqueue is Add value in last to stack
        {
            queue.Enqueue(add);
        }

        static void Remove() //Dequeue is Remove value in last to stack
        {
            queue.Dequeue();
        }

        static void Clear() //Clear All value to queue
        {
            queue.Clear();
        }

        static void QueueList()
        {
            Console.WriteLine("This list your queue : ");
            foreach(var que in queue)
            {
                Console.WriteLine(que);
            }
            Console.WriteLine();
        }
    }
}
