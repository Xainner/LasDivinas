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
    public partial class UcSettings : UserControl
    {
        public UcSettings()
        {
            InitializeComponent();
        }

        private void LibertyButtons_Click(object sender, EventArgs e)
        {
            FrmMain.Instance.DraggablePanelColor.BackColor = Color.FromArgb(71, 71, 135);
            FrmMain.Instance.StatusStripColor.BackColor = Color.FromArgb(71, 71, 135);
            Properties.Settings.Default.Theme = "71, 71, 135";
            Properties.Settings.Default.Save();
        }

        private void DesertButtons_Click(object sender, EventArgs e)
        {
            FrmMain.Instance.DraggablePanelColor.BackColor = Color.FromArgb(204, 174, 98);
            FrmMain.Instance.StatusStripColor.BackColor = Color.FromArgb(204, 174, 98);
            Properties.Settings.Default.Theme = "204, 174, 98";
            Properties.Settings.Default.Save();
        }

        private void EyeOfNewtButtons_Click(object sender, EventArgs e)
        {
            FrmMain.Instance.DraggablePanelColor.BackColor = Color.FromArgb(179, 57, 57);
            FrmMain.Instance.StatusStripColor.BackColor = Color.FromArgb(179, 57, 57);
            Properties.Settings.Default.Theme = "179, 57, 57";
            Properties.Settings.Default.Save();
        }

        private void PalmSpringsSplashButtons_Click(object sender, EventArgs e)
        {
            FrmMain.Instance.DraggablePanelColor.BackColor = Color.FromArgb(33, 140, 116);
            FrmMain.Instance.StatusStripColor.BackColor = Color.FromArgb(33, 140, 116);
            Properties.Settings.Default.Theme = "33, 140, 116";
            Properties.Settings.Default.Save();
        }

        private void HotStoneButtons_Click(object sender, EventArgs e)
        {
            FrmMain.Instance.DraggablePanelColor.BackColor = Color.FromArgb(170, 166, 157);
            FrmMain.Instance.StatusStripColor.BackColor = Color.FromArgb(170, 166, 157);
            Properties.Settings.Default.Theme = "170, 166, 157";
            Properties.Settings.Default.Save();
        }
    }
}
