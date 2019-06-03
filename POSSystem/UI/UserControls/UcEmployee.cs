using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POSSystemLibrary.Management;
using POSSystemLibrary.Models;
using MetroFramework;

namespace UI.UserControls
{
    public partial class UcEmployee : UserControl
    {
        //---------GLOBALS---------
        List<EmployeeModel> employeeModels;

        public UcEmployee()
        {
            InitializeComponent();
        }

        private void UcEmployee_Load(object sender, EventArgs e)
        {
            ReloadEmployees();
        }

        //--------------------Metodos de actualizaciones-------------------------

        private void ReloadEmployees()
        {
            employeeModels = EmployeeManagement.SelectAllEmployees();
            EmployeeDataGridView.MultiSelect = false;
            EmployeeDataGridView.DataSource = employeeModels;

            EmployeeDataGridView.Columns["Id_Employee"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeDataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeDataGridView.Columns["LastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeDataGridView.Columns["Telephone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeDataGridView.Columns["Identification_Type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeDataGridView.Columns["Identification"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeDataGridView.Columns["Born_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeDataGridView.Columns["Registration_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            EmployeeDataGridView.Columns["Id_Employee"].HeaderText = "Id";
            EmployeeDataGridView.Columns["Name"].HeaderText = "Nombre";
            EmployeeDataGridView.Columns["LastName"].HeaderText = "Apellidos";
            EmployeeDataGridView.Columns["Telephone"].HeaderText = "Teléfono";
            EmployeeDataGridView.Columns["Identification_Type"].HeaderText = "Tipo de Identificación";
            EmployeeDataGridView.Columns["Identification"].HeaderText = "Identificación";
            EmployeeDataGridView.Columns["Born_Date"].HeaderText = "Fecha de Nacimiento";
            EmployeeDataGridView.Columns["Registration_Date"].HeaderText = "Fecha de Registro";

            EmployeeDataGridView.Columns["Id_Employee"].Visible = false;
            EmployeeDataGridView.Columns["Born_Date"].DefaultCellStyle.Format = "d";
            EmployeeDataGridView.Columns["Registration_Date"].DefaultCellStyle.Format = "d";

            EmployeeDataGridView.Columns["Born_Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeeDataGridView.Columns["Registration_Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            EmployeeDataGridView.Columns["Identification"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            try
            {
                Clear();
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, $"Ha ocurrido un error al limpiar la ventana.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(LastNameTextBox.Text))
                {
                    DateTime bornDate = BornDateTimePicker.Value;
                    DateTime fecha = DateTime.Now;

                    if (EmployeeManagement.InsertEmployee(NameTextBox.Text, LastNameTextBox.Text, PhoneNumberTextBox.Text, IdTypeComboBox.SelectedItem.ToString(),
                                                            IdentificationTextBox.Text, bornDate, fecha))
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Se agrego el Empleado correctamente.";
                        Clear();
                        ReloadEmployees();
                    }
                    else
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Error! No se pudo agregar el Empleado.";
                    }
                }
                else
                {
                    FrmMain.Instance.ToolStripLabel.Text = "Error! El nombre y apellido son campos obligarios.";
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, $"Ha ocurrido un error al agregar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!IdLabel.Text.Equals("none"))
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(LastNameTextBox.Text) && EmployeeDataGridView.CurrentRow.Cells[0].Value.ToString() != null)
                {
                    if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar al empleado: { EmployeeDataGridView.CurrentRow.Cells[1].Value.ToString() }?", "Modificar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (EmployeeManagement.UpdateEmployeeById(int.Parse(IdLabel.Text), NameTextBox.Text, LastNameTextBox.Text, PhoneNumberTextBox.Text, IdTypeComboBox.SelectedItem.ToString(),
                            IdentificationTextBox.Text, BornDateTimePicker.Value))
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "Se modifico el Empleado correctamente.";
                            Clear();
                            ReloadEmployees();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar al empleado: { NameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!IdLabel.Text.Equals("none"))
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(LastNameTextBox.Text) && EmployeeDataGridView.CurrentRow.Cells[0].Value.ToString() != null)
                {
                    int Id = int.Parse(IdLabel.Text);

                    if (EmployeeManagement.DeleteEmployeeById(Id))
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Se elimino el Empleado correctamente.";
                        Clear();
                        ReloadEmployees();
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

        private void EmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (EmployeeDataGridView.SelectedRows[0] != null)
                {
                    IdLabel.Text = EmployeeDataGridView.CurrentRow.Cells[0].Value.ToString();
                    NameTextBox.Text = EmployeeDataGridView.CurrentRow.Cells[1].Value.ToString();
                    LastNameTextBox.Text = EmployeeDataGridView.CurrentRow.Cells[2].Value.ToString();
                    PhoneNumberTextBox.Text = EmployeeDataGridView.CurrentRow.Cells[3].Value.ToString();
                    IdentificationTextBox.Text = EmployeeDataGridView.CurrentRow.Cells[5].Value.ToString();
                    BornDateTimePicker.Text = EmployeeDataGridView.CurrentRow.Cells[6].Value.ToString();

                    foreach (string idTypes in IdTypeComboBox.Items)
                    {
                        if (idTypes.Equals(EmployeeDataGridView.CurrentRow.Cells[4].Value.ToString()))
                        {
                            IdTypeComboBox.SelectedItem = idTypes;
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, $"Ha ocurrido un error al seleccionar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
