# LocoBuzz_Collection_Framework
Collection in C# represent a group of objects. By help of collection we perform various operations on objects like:
+ Store
+ Update
+ Delete
+ Retrive
+ Search

# Types of Collections:
There are three different ways to work with Collections.
--System.Collections.Generic classes
  + List
  + Stack
  + Queue
  + Linked List
  + Hash Set
  + Sorted Set
  + Dictionary
  + Sorted Dictionary
  + Sorted List
--System.Collections classes (Now deprecated)
  + ArrayList
  + Stack
  + Queue
  + Hash Table
--System.Collections.Concurrent classes

# List 
List<T> class is used to store and fetch elements. It can have duplicate elements.
Inbuilt function are:
+ .Add(3)
+ .Remove()
+ .AddRange()
+ .RemoveAt(0) //to remove at particular location
+ .IndexOf(<value>)

# Queue
Queue<T> class is used to Enqueue and Dequeue elements. It uses the concept of Queue that arranges elements in FIFO (First In First Out) order. It can have duplicate elements.
Inbuilt function are:
+ .Enqueue(1);
+ .Dequeue();
+ .Peek();
+ .Count();
+ .Clear();
+ .Contains(2);
+ .ToArray();

# Stack
Stack<T> class is used to push and pop elements. It uses the concept of Stack that arranges elements in LIFO (Last In First Out) order. It can have duplicate elements.
Inbuilt function are:
+ .Push(1);
+ .Pop();
+ .Peek();
+ .Count;
+ .Clear();
+ .Contains(2);
+ .ToArray();
