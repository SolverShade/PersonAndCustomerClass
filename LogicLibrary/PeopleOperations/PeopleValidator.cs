using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.PeopleOperations
{
    public static class PeopleValidator
    {
        public static bool NameValid(string name)
        {
            int wordCount = name.Split(' ').Length;

            if(wordCount == 2)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        public static bool PhoneNumberValid(long phoneNumber)
        {
            int numberDigitCount = (int)Math.Floor(Math.Log10(phoneNumber) + 1);
            if (numberDigitCount == 10)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
