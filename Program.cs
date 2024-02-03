using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List<int> arr;
            arr = new List<int>();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);

            Console.WriteLine(arr.Count);   
            Console.WriteLine(arr.Contains(1));*/

            /*Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Count());

            Stack stack1 = new Stack();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Pop();
            stack1.Push(4);
            stack1.Push(5);
            Console.WriteLine(stack1.Count);
            Console.WriteLine(stack1.Peek());*/


            //Various operations for stack are 
            //Push()
            //Pop()
            //Peek


            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Dequeue();
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine(queue.Count());

            Stack queue1 = new Stack();
            queue1.Push(1);
            queue1.Push(2);
            queue1.Pop();
            queue1.Push(4);
            queue1.Push(5);
            Console.WriteLine(queue1.Count);
            Console.WriteLine(queue1.Peek());

        }
    }
}
