using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.People
{
    public class Customer : Person
    {
        public long BusinessNumber { get; set; }
        public bool OnMailingList { get; set; }

        public Customer(string name, long personalNumber, string address, long businessNumber, bool onMailingList) 
            : base(name, personalNumber, address)
        {
            BusinessNumber = businessNumber;
            OnMailingList = onMailingList; 
        }
    }
}
