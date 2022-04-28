using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public class StatusMessanger
    {
        public Label StatusLabel { get; set; }

        public StatusMessanger(Label statusLabel)
        {
            StatusLabel = statusLabel; 
        }

        public void ShowInvalidName()
        {
            StatusLabel.Text = "Status: Please Enter a valid full name ";
        }

        public void ShowInvalidNumber(string numberType)
        {
            StatusLabel.Text = "Status: Please Enter a valid 10 digit " + numberType + " phone number";
        }

        public void ShowInvalidAddress()
        {
            StatusLabel.Text = "Status: Please Enter a Valid Address";
        }

        public void ShowSignUpSuccess()
        {
            StatusLabel.Text = "Status: Success regestration complete";
        }

        public void ClearStatus()
        {
            StatusLabel.Text = "Status:";
        }
    }
}
