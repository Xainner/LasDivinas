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
    public partial class UcClients : UserControl
    {
        //---------GLOBALS---------
        List<ClientModel> clientModels;

        public UcClients()
        {
            InitializeComponent();
        }

        // Methods
        private void Clear()
        {
            IdLabel.Text = "none";
            NameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            BornDateTimePicker.Text = string.Empty;
            IdentificationTextBox.Text = string.Empty;
            SearchTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
        }

        private void UcClients_Load(object sender, EventArgs e)
        {
            ReloadClient();

        }

        //--------------------Metodos de actualizaciones-------------------------

        private void ReloadClient()
        {
            clientModels = ClientManagement.SelectAllClients();
            ClientDataGridView.MultiSelect = false;
            ClientDataGridView.DataSource = clientModels;

            ClientDataGridView.Columns["Id_Client"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClientDataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClientDataGridView.Columns["LastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClientDataGridView.Columns["Identification_Type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClientDataGridView.Columns["Identification"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClientDataGridView.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClientDataGridView.Columns["Born_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ClientDataGridView.Columns["Registration_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            ClientDataGridView.Columns["Id_Client"].HeaderText = "Id";
            ClientDataGridView.Columns["Name"].HeaderText = "Nombre";
            ClientDataGridView.Columns["LastName"].HeaderText = "Apellidos";            
            ClientDataGridView.Columns["Identification_Type"].HeaderText = "Tipo de Identificación";
            ClientDataGridView.Columns["Identification"].HeaderText = "Identificación";
            ClientDataGridView.Columns["Email"].HeaderText = "Correo electronico";
            ClientDataGridView.Columns["Born_Date"].HeaderText = "Fecha de Nacimiento";
            ClientDataGridView.Columns["Registration_Date"].HeaderText = "Fecha de Registro";

            ClientDataGridView.Columns["Id_Client"].Visible = false;
            ClientDataGridView.Columns["Born_Date"].DefaultCellStyle.Format = "d";
            ClientDataGridView.Columns["Registration_Date"].DefaultCellStyle.Format = "d";

            ClientDataGridView.Columns["Born_Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ClientDataGridView.Columns["Registration_Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ClientDataGridView.Columns["Identification"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                    DateTime fecha = DateTime.Now;

                    if (ClientManagement.InsertClient(NameTextBox.Text, LastNameTextBox.Text, IdTypeComboBox.SelectedItem.ToString(),
                        IdentificationTextBox.Text, EmailTextBox.Text, BornDateTimePicker.Value, fecha))
                    {
                        FrmMain.Instance.ToolStripLabel.Text = "Se agrego el Cliente correctamente.";
                        Clear();
                        ReloadClient();
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
                if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(LastNameTextBox.Text) 
                    && ClientDataGridView.CurrentRow.Cells[0].Value.ToString() != null)
                {

                    if (MetroMessageBox.Show(this, $"¿Seguro que desea modificar al cliente: { ClientDataGridView.CurrentRow.Cells[1].Value.ToString() }?", "Modificar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (ClientManagement.UpdateClientById(int.Parse(IdLabel.Text), NameTextBox.Text, LastNameTextBox.Text, IdTypeComboBox.SelectedItem.ToString(),
                            IdentificationTextBox.Text, EmailTextBox.Text, BornDateTimePicker.Value))
                        {
                            FrmMain.Instance.ToolStripLabel.Text = "Se modifico el cliente correctamente.";
                            Clear();
                            ReloadClient();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido un error al modificar al cliente: { NameTextBox.Text}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
                        ReloadClient();
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
            clientModels = ClientManagement.SelectAllClients();
            ClientDataGridView.DataSource = clientModels;
        }

        // ------------------ METODOS DATAGRID ---------------------

        private void ClientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ClientDataGridView.SelectedRows[0] != null)
                {
                    IdLabel.Text = ClientDataGridView.CurrentRow.Cells[0].Value.ToString();
                    NameTextBox.Text = ClientDataGridView.CurrentRow.Cells[1].Value.ToString();
                    LastNameTextBox.Text = ClientDataGridView.CurrentRow.Cells[2].Value.ToString();
                    IdentificationTextBox.Text = ClientDataGridView.CurrentRow.Cells[4].Value.ToString();
                    EmailTextBox.Text = ClientDataGridView.CurrentRow.Cells[5].Value.ToString();
                    BornDateTimePicker.Text = ClientDataGridView.CurrentRow.Cells[6].Value.ToString();

                    foreach (string idTypes in IdTypeComboBox.Items)
                    {
                        if (idTypes.Equals(ClientDataGridView.CurrentRow.Cells[3].Value.ToString()))
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
