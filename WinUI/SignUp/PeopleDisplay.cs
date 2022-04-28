using LogicLibrary.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.SignUp
{
    public class PeopleDisplay
    {
        public ListBox CustomerListBox { get; set; }

        public PeopleDisplay(ListBox listBox)
        {
            CustomerListBox = listBox;
        }

        public void DisplayCustomers(List<Customer> customers)
        {
            CustomerListBox.ClearSelected();

            foreach (Customer customer in customers)
            {
                CustomerListBox.Items.Add("Name: " + customer.Name);
                CustomerListBox.Items.Add("Address " + customer.Address);
                CustomerListBox.Items.Add("Personal Phone Number " + customer.PersonalNumber.ToString());
                CustomerListBox.Items.Add("Business Phone Number " + customer.BusinessNumber.ToString());
                CustomerListBox.Items.Add("On Mailing List " + customer.OnMailingList.ToString());
                CustomerListBox.Items.Add("");
            }
        }
    }
}
