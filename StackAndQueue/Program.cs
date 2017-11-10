using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();
            MyStack myStack = new MyStack();

            /**
             * Queue - FIFO
             */
            myQueue.Enqueue("hello");       // entering 1
            myQueue.Enqueue("yalova");      // entering 2
            myQueue.Enqueue("university");  // entering 3

            while (!myQueue.IsEmpty())
            {
                Console.WriteLine(myQueue.Dequeue().item);
            }

            Console.WriteLine("\n==========================\n");

            /**
             * Stack - FILO
             */
            myStack.Push("hello");      // entering 1
            myStack.Push("yalova");     // entering 2
            myStack.Push("university"); // entering 3

            while (!myStack.IsEmpty())
            {
                Console.WriteLine(myStack.Pop().item);
            }
        }
    }
}
