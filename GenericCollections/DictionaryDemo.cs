using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class DictionaryDemo
    {
        public void DictionaryExample()
        {
            Person person1 = new Person()
            {
                Name = "Shanthi",
                Address = "Madurai",
                PhoneNo = 96234567
            };
            Person person2 = new Person()
            {
                Name = "venkat",
                Address = "chennai",
                PhoneNo = 9623456752
            };
            Dictionary<int, Person> dicperson = new Dictionary<int, Person>();
            dicperson.Add(1, person1);
            dicperson.Add(2, person2);
            foreach(KeyValuePair<int,Person> keyValuePair in dicperson)
            {
                Console.WriteLine("key={0}",keyValuePair.Key);
                Person p = keyValuePair.Value;
                Console.WriteLine("name={0} ,Adress={1} Phoneno={2}", p.Name, p.Address, p.PhoneNo);
                Console.WriteLine("-----------------------------------------------------------");

            }
            //Removemethod
            dicperson.Remove(2); // removes  2
                                 //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (dicperson.ContainsKey(3))
            { // check key before removing it
                dicperson.Remove(3);
            }
            else
            {
                Console.WriteLine("key not found");
            }
           
            // dicperson.Clear();

        }
    }
}

