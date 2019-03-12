using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UI.Forms;
using UI.UserControls;

namespace UI
{
    public partial class FrmMain : Form
    {
        static FrmMain _frmMain;

        /// <summary>
        /// Draggable panel for screen movement
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmMain()
        {
            InitializeComponent();
            _frmMain = this;
        }

        public static FrmMain Instance
        {
            get
            {
                if (_frmMain == null)
                {
                    _frmMain = new FrmMain();
                }
                return _frmMain;
            }
        }

        public Panel DraggablePanelColor
        {
            get { return DraggablePanel; }
            set { DraggablePanel = value; }
        }

        public StatusStrip StatusStripColor
        {
            get { return statusStrip1; }
            set { statusStrip1 = value; }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            HomeButton.PerformClick();
        }

        private void DraggablePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            About();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                MaximizeButton.Text = "↗";
            } else
            {
                WindowState = FormWindowState.Maximized;
                MaximizeButton.Text = "↙";
            }
        }

        //Methods//

        

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.ContainsKey("ucClients"))
            {
                UcClients ucClients = new UcClients();
                ucClients.Size = MainPanel.Size;
                ucClients.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
                MainPanel.Controls.Add(ucClients);
            }
            MainPanel.Controls["ucClients"].BringToFront();
            toolStripStatusLabel1.Text = "Sistema de facturación – Pantalla De Clientes.";
        }

        private void AboutButton2_Click(object sender, EventArgs e)
        {
            About();
        }

        //Custom//
        private void About()
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.Show();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.ContainsKey("ucSettings"))
            {
                UcSettings ucSettings = new UcSettings();
                ucSettings.Size = MainPanel.Size;
                ucSettings.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
                MainPanel.Controls.Add(ucSettings);
            }
            MainPanel.Controls["ucSettings"].BringToFront();
            toolStripStatusLabel1.Text = "Sistema de facturación – Configuración del Sistema.";
        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.ContainsKey("ucEmployees"))
            {
                UcEmployee ucEmployee = new UcEmployee();
                ucEmployee.Size = MainPanel.Size;
                ucEmployee.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
                MainPanel.Controls.Add(ucEmployee);
            }
            MainPanel.Controls["ucEmployee"].BringToFront();
            toolStripStatusLabel1.Text = "Sistema de facturación – Pantalla De Empleados.";
        }

        private void BusinessButton_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.ContainsKey("ucBusiness"))
            {
                UcBusiness ucBusiness = new UcBusiness();
                ucBusiness.Size = MainPanel.Size;
                ucBusiness.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
                MainPanel.Controls.Add(ucBusiness);
            }
            MainPanel.Controls["ucBusiness"].BringToFront();
            toolStripStatusLabel1.Text = "Sistema de facturación – Pantalla De Negocio.";
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.ContainsKey("ucHome"))
            {
                UcHome ucHome = new UcHome();
                ucHome.Size = MainPanel.Size;
                ucHome.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
                MainPanel.Controls.Add(ucHome);
            }
            MainPanel.Controls["ucHome"].BringToFront();
            toolStripStatusLabel1.Text = "Sistema de facturación – Pantalla de Inicio.";
        }

        private void AdministrationButton_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.ContainsKey("ucAdministration"))
            {
                UcAdministration ucAdministration = new UcAdministration();
                ucAdministration.Size = MainPanel.Size;
                ucAdministration.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
                MainPanel.Controls.Add(ucAdministration);
            }
            MainPanel.Controls["ucAdministration"].BringToFront();
            toolStripStatusLabel1.Text = "Sistema de facturación – Pantalla de Administración del Sistema.";
        }

        private void PurchaseOrderButton_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.ContainsKey("ucPurchaseOrder"))
            {
                UcPurchaseOrder ucPurchaseOrder = new UcPurchaseOrder();
                ucPurchaseOrder.Size = MainPanel.Size;
                ucPurchaseOrder.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
                MainPanel.Controls.Add(ucPurchaseOrder);
            }
            MainPanel.Controls["ucPurchaseOrder"].BringToFront();
            toolStripStatusLabel1.Text = "Sistema de facturación – Pantalla de Venta.";
        }
    }
}
