using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.People
{
    public class Person
    {
        public string Name { get; set; }
        public long PersonalNumber { get; set; }
        public string Address { get; set; } 

        public Person(string name, long personalNumber, string address)
        {
            Name = name;
            PersonalNumber = personalNumber;
            Address = address; 
        }
    }
}
