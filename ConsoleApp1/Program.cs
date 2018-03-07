using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
     
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push(4);
            myStack.Push(myStack);
            myStack.Pop();
            myStack.Peek();
            //Generic type safety used mostly with collections
            Stack<string> myStrStack = new Stack<string>();
            myStrStack.Push("Love");
            myStrStack.Push("Learn");
            //We can not add a integer because we said that 
            //our stack only store data of type string
            //myStrStack.Push(4);

        }
    }
}
