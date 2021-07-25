using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Person
    {
        
        public string Name { get; set; }
        public string Address  { get; set; }
        public long PhoneNo { get; set; }
      public Person()
        {

        }
        public Person (string name, string address,long phoneno)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNo = phoneno;
        }

    }
}
