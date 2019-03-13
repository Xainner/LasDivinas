using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POSSystemLibrary.Management;

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
            ClientDataGridView.DataSource = ClientManagement.SelectAllClients();
        }

        private void SearchTextBox_ButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchTextBox.Text))
            {
                ClientDataGridView.DataSource = ClientManagement.SelectMultipleClients(SearchTextBox.Text);

                FrmMain.Instance.ToolStripLabel.Text = "Lista de Clientes cargada correctamente.";
                Clear();
            }
            else
            {
                FrmMain.Instance.ToolStripLabel.Text = "Error! El campo buscar no puede ser vacio.";
            }
        }

        private void AddButton_Click_1(object sender, EventArgs e)
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

                    if (ClientManagement.InsertClient(name, lastName, idType, identification, email, bornDate))
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Se agrego el Cliente correctamente.";
                        Clear();
                    }
                    else
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Error! No se pudo agregar el Cliente.";
                    }

                }
                else
                {

                }
            }
        }

        private void ModifyButton_Click_1(object sender, EventArgs e)
        {
            if (!IdLabel.Text.Equals("none"))
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(LastNameTextBox.Text))
                {
                    int Id = int.Parse(IdLabel.Text);
                    string name = NameTextBox.Text;
                    string lastName = LastNameTextBox.Text;
                    string phoneNumber = PhoneNumberTextBox.Text;
                    string idType = IdTypeComboBox.SelectedValue.ToString();
                    string identification = IdentificationTextBox.Text;
                    DateTime bornDate = BornDateTimePicker.Value;
                    string email = EmailTextBox.Text;

                    if (ClientManagement.UpdateClientById(Id, name, lastName, idType, identification, email, bornDate))
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Se modifico el Cliente correctamente.";
                        Clear();
                    }
                    else
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Error! No se pudo modificar el Cliente.";
                    }
                }
                else
                {

                }
            }
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            if (!IdLabel.Text.Equals("none"))
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(LastNameTextBox.Text))
                {
                    int Id = int.Parse(IdLabel.Text);

                    if (ClientManagement.DeleteClientById(Id))
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Se elimino el Cliente correctamente.";
                        Clear();
                    }
                    else
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Error! No se pudo eliminar el Cliente.";
                    }
                }
                else
                {

                }
            }
        }

        private void NewButton_Click_1(object sender, EventArgs e)
        {
            Clear();
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
            EmailTextBox.Text = string.Empty;
        }
    }
}
