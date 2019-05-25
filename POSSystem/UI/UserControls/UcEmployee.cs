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
    public partial class UcEmployee : UserControl
    {
        public UcEmployee()
        {
            InitializeComponent();
        }

        private void UcEmployee_Load(object sender, EventArgs e)
        {
            EmployeeDataGridView.DataSource = EmployeeManagement.SelectAllEmployees();
        }

        private void SearchTextBox_ButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchTextBox.Text))
            {
                EmployeeDataGridView.DataSource = EmployeeManagement.SelectMultipleEmployees(SearchTextBox.Text);

                FrmMain.Instance.ToolStripLabel.Text = "Lista de Empleados cargada correctamente.";
                Clear();
            }
            else
            {
                FrmMain.Instance.ToolStripLabel.Text = "Error! El campo buscar no puede ser vacio.";
            }
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IdLabel.Text.Equals("none"))
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(LastNameTextBox.Text))
                {
                    string name = NameTextBox.Text;
                    string lastName = LastNameTextBox.Text;
                    string phoneNumber = PhoneNumberTextBox.Text;
                    string idType = IdTypeComboBox.SelectedItem.ToString();
                    string identification = IdentificationTextBox.Text;
                    DateTime bornDate = BornDateTimePicker.Value;
                    DateTime fecha = DateTime.Now;

                    if (EmployeeManagement.InsertEmployee(name, lastName, phoneNumber, idType, identification, bornDate, fecha))
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Se agrego el Empleado correctamente.";
                        Clear();
                    }
                    else
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Error! No se pudo agregar el Empleado.";
                    }
                }
                else
                {

                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
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

                    if (EmployeeManagement.UpdateEmployeeById(Id, name, lastName, phoneNumber, idType, identification, bornDate))
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Se modifico el Empleado correctamente.";
                        Clear();
                    }
                    else
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Error! No se pudo modificar el Empleado.";
                    }
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
                if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(LastNameTextBox.Text))
                {
                    int Id = int.Parse(IdLabel.Text);

                    if (EmployeeManagement.DeleteEmployeeById(Id))
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Se elimino el Empleado correctamente.";
                        Clear();
                    }
                    else
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Error! No se pudo eliminar el Empleado.";
                    }
                }
                else
                {

                }
            }
        }

        // ------------------ METODOS ---------------------

        private void Clear()
        {
            NameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            PhoneNumberTextBox.Text = string.Empty;
            IdentificationTextBox.Text = string.Empty;
            PhoneNumberTextBox.Text = string.Empty;
            BornDateTimePicker.Text = string.Empty;
            SearchTextBox.Text = string.Empty;
        }
    }
}
