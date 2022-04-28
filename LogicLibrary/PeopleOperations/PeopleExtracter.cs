using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.PeopleOperations
{
    public static class PeopleExtracter
    {
        public static long BuildPhoneNumber(string userNumberText)
        {
            userNumberText = userNumberText.Replace("-", String.Empty);
            userNumberText.Trim();
            
            bool success  = long.TryParse(userNumberText, out long phoneNumber);

            if (success)
            {
                return phoneNumber;
            }
            else
            {
                return -1; 
            }
        }
    }
}
