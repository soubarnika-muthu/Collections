using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class ListDemo
    {
        public void ListExample()
        {
            List<Person> personList = new List<Person>();
            Person person = new Person("sou", "TamilNadu", 9629522931);
            Person person1 = new Person("Gemini", "Delhi", 8320522831);

            personList.Add(person);
            personList.Add(person1);

            foreach (var p in personList)
            {
                Console.WriteLine(p.Name);
            }
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
           
            //InsertOperations
            primeNumbers.Insert(4, 11);
          
            //REMOVE method
           primeNumbers.Remove(1); // removes the first 10 from a list

            primeNumbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            try
            {
                primeNumbers.RemoveAt(10); //throws ArgumentOutOfRangeException
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            //accesing  elements in alist
         
            //Adding strings
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");
            foreach(string i in colors)
                Console.WriteLine(i);
        }


    }
}
