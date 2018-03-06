using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BildingCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Non-Generic Collections
            ArrayList arrayList = new ArrayList();
            arrayList.Add(12);
            arrayList.Add("hey");
            Stack myStack = new Stack();
            myStack.Push("hello");
            myStack.Push(43);
            myStack.Peek();
            Queue myQueue = new Queue();
            myQueue.Enqueue("hello");
            myQueue.Enqueue(45);
            
            SortedList strList = new SortedList();
            strList.Add(1, 23);
            strList.Add(2, 65);

        

            //Generic Collectiosn
            Stack<int> numbers = new Stack<int>();
            Queue<char> letters = new Queue<char>();
            SortedList<string, string> love = new SortedList<string, string>();


        }
    }
}
