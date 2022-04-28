using LogicLibrary.People;
using LogicLibrary.PeopleOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.SignUp;

namespace WinUI
{
    public partial class Form1 : Form
    {
        private StatusMessanger statusMessanger;
        private PeopleDisplay peopleDisplay;
        private List<Customer> customers = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusMessanger = new StatusMessanger(StatusLabel);
            peopleDisplay = new PeopleDisplay(CustomerListBox);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            statusMessanger.ClearStatus();

            string name = "";
            long personalNumber = -1;
            string address = "";
            long businessNumber = -1;
            bool onMailingList = MailingListCheckBox.Checked;

            if (PeopleValidator.NameValid(NameTextBox.Text))
            {
                name = NameTextBox.Text;
            }
            else
            {
                statusMessanger.ShowInvalidName();
            }
            if (PeopleValidator.PhoneNumberValid(PeopleExtracter.BuildPhoneNumber(PersonalCellNumberTextBox.Text)))
            {
                personalNumber = PeopleExtracter.BuildPhoneNumber(PersonalCellNumberTextBox.Text);
            }
            else
            {
                statusMessanger.ShowInvalidNumber("Personal");
            }
            if (HomeAddressTextBox.Text.Length > 0)
            {
                address = HomeAddressTextBox.Text;
            }
            else
            {
                statusMessanger.ShowInvalidAddress();
            }
            if (PeopleValidator.PhoneNumberValid(PeopleExtracter.BuildPhoneNumber(BusinessCellNumberTextBox.Text)))
            {
                businessNumber = PeopleExtracter.BuildPhoneNumber(BusinessCellNumberTextBox.Text);
            }
            else
            {
                statusMessanger.ShowInvalidNumber("Business");
            }

            if (name != "" && personalNumber != -1 && address != "" && businessNumber != -1)
            {
                customers.Add(new Customer(name, personalNumber, address, businessNumber, onMailingList));
                peopleDisplay.DisplayCustomers(customers);
                statusMessanger.ShowSignUpSuccess();
            }


        }
    }
}
