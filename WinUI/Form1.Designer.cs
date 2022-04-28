
namespace WinUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonalCellNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HomeAddressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MailingListCheckBox = new System.Windows.Forms.CheckBox();
            this.BusinessCellNumberTextBox = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.CustomerListBox = new System.Windows.Forms.ListBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(126, 6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personal Cell Number";
            // 
            // PersonalCellNumberTextBox
            // 
            this.PersonalCellNumberTextBox.Location = new System.Drawing.Point(126, 37);
            this.PersonalCellNumberTextBox.Name = "PersonalCellNumberTextBox";
            this.PersonalCellNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.PersonalCellNumberTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Home Address";
            // 
            // HomeAddressTextBox
            // 
            this.HomeAddressTextBox.Location = new System.Drawing.Point(126, 69);
            this.HomeAddressTextBox.Name = "HomeAddressTextBox";
            this.HomeAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.HomeAddressTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Business Cell Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 7;
            // 
            // MailingListCheckBox
            // 
            this.MailingListCheckBox.AutoSize = true;
            this.MailingListCheckBox.Location = new System.Drawing.Point(14, 146);
            this.MailingListCheckBox.Name = "MailingListCheckBox";
            this.MailingListCheckBox.Size = new System.Drawing.Size(140, 17);
            this.MailingListCheckBox.TabIndex = 8;
            this.MailingListCheckBox.Text = "Subscribe to Mailing List";
            this.MailingListCheckBox.UseVisualStyleBackColor = true;
            // 
            // BusinessCellNumberTextBox
            // 
            this.BusinessCellNumberTextBox.Location = new System.Drawing.Point(126, 120);
            this.BusinessCellNumberTextBox.Name = "BusinessCellNumberTextBox";
            this.BusinessCellNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.BusinessCellNumberTextBox.TabIndex = 9;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(14, 188);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.SignUpButton.TabIndex = 10;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // CustomerListBox
            // 
            this.CustomerListBox.FormattingEnabled = true;
            this.CustomerListBox.Location = new System.Drawing.Point(272, 23);
            this.CustomerListBox.Name = "CustomerListBox";
            this.CustomerListBox.Size = new System.Drawing.Size(210, 199);
            this.CustomerListBox.TabIndex = 11;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(12, 227);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 12;
            this.StatusLabel.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 249);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CustomerListBox);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.BusinessCellNumberTextBox);
            this.Controls.Add(this.MailingListCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HomeAddressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PersonalCellNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Customer Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PersonalCellNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HomeAddressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox MailingListCheckBox;
        private System.Windows.Forms.TextBox BusinessCellNumberTextBox;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.ListBox CustomerListBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label6;
    }
}

