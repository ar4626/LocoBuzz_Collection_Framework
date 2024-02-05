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


            /*//Dictionary
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
            }*/

            //HASHSET


            // C# HashSet class can be used to store, remove or view elements. It does not store duplicate elements.
            // It is suggested to use HashSet class if you have to store only unique elements.
            //It is generic collection 
            HashSet<string> names = new HashSet<string>();

            // Add() -> used to add or store elements or objects in Hashset
            names.Add("Aman");
            names.Add("Ashish");
            names.Add("Atharva");
            names.Add("Prince");
            // Iterate HashSet elements using foreach loop

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //Let's see another example of generic HashSet<T> class that stores elements using Collection initializer.

            var hs = new HashSet<string>() { "Sonoo", "Ankit", "Peter", "Irfan" };

            // Iterate HashSet elements using foreach loop  
            foreach (var name in hs)
            {
                Console.WriteLine(name);
            }
            //Count: Gets the number of elements contained in the HashSet<T>
            Console.WriteLine("No of object in hs hashset: " + hs.Count);

            //Remove(T item): Removes the specified element from the HashSet< T>

            hs.Remove("Peter");

            //Contains(T item): Determines whether the HashSet<T> contains a specific value
            bool containsele = hs.Contains("Prince");
            Console.WriteLine("hs Hashset contains Prince : " + containsele);



            //Clear(): Removes all elements from the HashSet<T>.
            hs.Clear();

            //HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };

            //HashSet<int> set2 = new HashSet<int> { 5,6, 3,7, 8, 7, 9 };

            ////UnionWith(IEnumerable < T > other): Modifies the current set to contain all elements present in itself,
            ////in the specified collection, or in both.
            ////set1.UnionWith(set2);
            //foreach(var i in set1)
            //{
            //    Console.Write(i+" "); //print the union of set1 and set2
            //}
            //Console.WriteLine();
            ////IntersectWith(IEnumerable<T> other): Modifies the current set to contain only elements that
            ////are present in both the set and the specified collection.
            ////// Modifies set1 to contain only elements present in both set1 and set2
            //set1.IntersectWith(set2);
            //Console.WriteLine("Modified set1:");
            //foreach (var item in set1)
            //{
            //    Console.Write(item+" ");
            //}

            //IsSubsetOf(IEnumerable<T> other): Determines whether the HashSet<T> is a subset of a specified collection.
            HashSet<int> set1 = new HashSet<int> { 1, 2 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4, 5 };
            bool isSubset = set1.IsSubsetOf(set2);
            Console.WriteLine("set1 is subset of set2 : " + isSubset);

            //IsSupersetOf(IEnumerable<T> other): Determines whether the HashSet<T> is a superset of a specified collection.
            Console.WriteLine("set2 is superset of set1 : " + set2.IsSupersetOf(set1));






        }
    }

}
