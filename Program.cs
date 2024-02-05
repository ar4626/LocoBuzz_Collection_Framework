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


            /*Queue<int> queue = new Queue<int>();
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
            Console.WriteLine(queue1.Peek());*/

            //LINKED LIST
            /*var names = new LinkedList<string>();
            names.AddLast("Sonoo");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");

            //insert new element before "Peter"  
            LinkedListNode<String> node = names.Find("Peter");
            names.AddBefore(node, "John");
            names.AddAfter(node, "Lucy");

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }*/


            //Dictionary
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "Sonoo");
            names.Add("2", "Peter");
            names.Add("3", "James");
            names.Add("4", "Ratan");
            names.Add("5", "Irfan");

            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            int count = names.Count;
            Console.WriteLine("Number of elements in the dictionary: " + count);

            bool containsKey = names.ContainsKey("2");
            Console.WriteLine("Does the dictionary contain key '2'? " + containsKey);

            bool containsValue = names.ContainsValue("Ratan");
            Console.WriteLine("Does the dictionary contain value 'Ratan'? " + containsValue);

            names.Remove("3");
            Console.WriteLine("Element with key '3' removed.");

            Console.WriteLine("Keys in the dictionary:");
            foreach (var key in names.Keys)
            {
                Console.WriteLine(key);
            }




        }
    }

}
