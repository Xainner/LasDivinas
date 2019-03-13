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
    public partial class UcBusiness : UserControl
    {
        public UcBusiness()
        {
            InitializeComponent();
        }

        private void UcBusiness_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_ButtonClick(object sender, EventArgs e)
        {

        }

        private void CleanButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text) && !string.IsNullOrEmpty(LegalDocumentTextBox.Text))
            {
                int Id = 1;
                string name = NameTextBox.Text;
                string societyName = SocietyNameTextBox.Text;
                string legalDocument = LegalDocumentTextBox.Text;
                string telephone = TelephoneTextBox.Text;
                string email = EmailTextBox.Text;
                string webPage = WebPageTextBox.Text;
                string address = AddressTextBox.Text;
                //byte logo = LogoPictureBox.GetHashCode;

                //if (BusinessManagement.UpdateBusinessById(Id, name, societyName, legalDocument, telephone, address, email, webPage, logo))
                //{
                //    FrmMain.Instance.ToolStripLabel.Text = "Se modifico el Negocio correctamente.";
                //    Clear();
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
            SearchButton.Text = string.Empty;
        }
    }
}
