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

namespace UI.UserControls
{
    public partial class UcBusiness : UserControl
    {
        //---------GLOBALS---------
        List<BusinessModel> businessModels;

        public UcBusiness()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            NameTextBox.Text = string.Empty;
            SocietyNameTextBox.Text = string.Empty;
            LegalDocumentTextBox.Text = string.Empty;
            TelephoneTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            WebPageTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;
            LogoPictureBox.Text = string.Empty;
        }

        private void ReloadBusiness()
        {
            businessModels = BusinessManagement.SelectAllBusiness();
            BusinessDataGridView.MultiSelect = false;
            BusinessDataGridView.DataSource = businessModels;

            BusinessDataGridView.Columns["Id_Business"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BusinessDataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BusinessDataGridView.Columns["Society_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BusinessDataGridView.Columns["LegalCertification"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BusinessDataGridView.Columns["Telephone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BusinessDataGridView.Columns["Main_Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BusinessDataGridView.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BusinessDataGridView.Columns["WebPage"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BusinessDataGridView.Columns["Logo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            BusinessDataGridView.Columns["Id_Business"].HeaderText = "Id";
            BusinessDataGridView.Columns["Name"].HeaderText = "Nombre";
            BusinessDataGridView.Columns["Society_Name"].HeaderText = "Nombre de Sociedad";
            BusinessDataGridView.Columns["LegalCertification"].HeaderText = "Cédula Jurídica";
            BusinessDataGridView.Columns["Telephone"].HeaderText = "Teléfono";
            BusinessDataGridView.Columns["Main_Address"].HeaderText = "Dirección";
            BusinessDataGridView.Columns["Email"].HeaderText = "Correo Electronico";
            BusinessDataGridView.Columns["WebPage"].HeaderText = "Página Web";
            BusinessDataGridView.Columns["Logo"].HeaderText = "Logo";

            BusinessDataGridView.Columns["Id_Business"].Visible = false;
            BusinessDataGridView.Columns["Logo"].Visible = false;

            BusinessDataGridView.Columns["LegalCertification"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void UcBusiness_Load(object sender, EventArgs e)
        {
            ReloadBusiness();
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(LegalDocumentTextBox.Text))
            {
                //if (BusinessManagement.UpdateBusinessById(1, NameTextBox.Text, SocietyNameTextBox.Text, LegalDocumentTextBox.Text,
                //    TelephoneTextBox.Text, AddressTextBox.Text, EmailTextBox.Text, WebPageTextBox.Text, LogoPictureBox.GetHashCode))
                //{
                //    FrmMain.Instance.ToolStripLabel.Text = "Se modifico el Negocio correctamente.";
                //    Clear();
                //    ReloadBusiness();
                //}
                //else
                //{
                //    FrmMain.Instance.ToolStripLabel.Text = "Error! No se pudo modificar el Negocio.";
                //}
            }
            else
            {

            }
        }

        // ------------------ METODOS ---------------------


    }
}
