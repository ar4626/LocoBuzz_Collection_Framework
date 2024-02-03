using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr;
            arr = new List<int>();

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);

            Console.WriteLine(arr.Count);   
            Console.WriteLine(arr.Contains(1));
        }
    }
}
