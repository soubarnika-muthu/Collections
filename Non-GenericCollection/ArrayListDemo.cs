using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_GenericCollection
{
    class ArrayListDemo
    {
        public void ArrayListExample()
        {
            //object creation 
            // ArrayList arrayList = new ArrayList();
            //or
            var arlist1 = new ArrayList();
            // adding elements using ArrayList.Add() method

            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);
            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
                {
                    2, "Steve", " ", true, 4.5, null
                };
           
           // AddRange method to add an entire Array,Stack,queue
            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist1.AddRange(arlist2); //adding arraylist in arraylist 
            arlist1.AddRange(arr); //adding array in arraylist 
            arlist1.AddRange(myQ); //adding Queue in arraylist 
           
           
            //REMOVE Method
            arlist1.Remove(null); //Removes first occurance of null
            arlist1.RemoveAt(4); //Removes element at index 4
            arlist1.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            //CHECKMETHOD
            Console.WriteLine(arlist1.Contains(300)); // True
            Console.WriteLine("Displaying Elements in list");
            foreach (var item in arlist1)
            {
                Console.WriteLine(item + ", ");
            }
            var Eigthelement = arlist1[7];
            Console.WriteLine("item={0} ", Eigthelement);
        }
    }
}
