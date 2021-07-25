using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class QueueDemo
    {
        public void QueueExample()
        {
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
                Console.WriteLine(id); //prints 1234
            if (callerIds.Count > 0)
                Console.WriteLine("After Deque:"+callerIds.Dequeue()); //prints 1

            Console.WriteLine("Total elements: {0}", callerIds.Count);
            if (callerIds.Count > 0)
            {
                Console.WriteLine(callerIds.Peek()); //prints 1
                
            }

        }
    }
}
