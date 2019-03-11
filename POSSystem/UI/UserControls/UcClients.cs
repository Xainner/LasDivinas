using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.UserControls
{
    public partial class UcClients : UserControl
    {
        public UcClients()
        {
            InitializeComponent();
        }

        private void UcClients_Load(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_ButtonClick(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IdLabel.Text.Equals("none"))
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(LastNameTextBox.Text))
                {
                    string name = NameTextBox.Text;
                    string lastName = LastNameTextBox.Text;
                    string phoneNumber = PhoneNumberTextBox.Text;
                    string idType = IdTypeComboBox.SelectedValue.ToString();
                    string identification = IdentificationTextBox.Text;
                    DateTime bornDate = BornDateTimePicker.Value;
                    string email = EmailTextBox.Text;


                } else
                {

                }
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (!IdLabel.Text.Equals("none"))
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(LastNameTextBox.Text))
                {
                    string name = NameTextBox.Text;
                    string lastName = LastNameTextBox.Text;
                    string phoneNumber = PhoneNumberTextBox.Text;
                    string idType = IdTypeComboBox.SelectedValue.ToString();
                    string identification = IdentificationTextBox.Text;
                    DateTime bornDate = BornDateTimePicker.Value;
                    string email = EmailTextBox.Text;


                }
                else
                {

                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!IdLabel.Text.Equals("none"))
            {
                
            }
        }

        // Methods
        private void Clear()
        {
            NameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            PhoneNumberTextBox.Text = string.Empty;
            IdentificationTextBox.Text = string.Empty;
            PhoneNumberTextBox.Text = string.Empty;
            SearchTextBox.Text = string.Empty;
        }
    }
}
