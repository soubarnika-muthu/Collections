using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class StackDemo
    {
        public void StackExample()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            foreach (var item in myStack)
                Console.WriteLine(item );
            //CountMethod
            Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
            //Popmethod
            if(myStack.Count > 0)
                Console.WriteLine("Popped element:{0}",myStack.Pop());
            //PeekMethod
            if (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Peek()); // prints 3
                
            }
            //Conatins
            myStack.Contains(2); // returns true
            myStack.Contains(10); // returns false



        }
    }
}
