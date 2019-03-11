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
    public partial class UcHome : UserControl
    {
        public UcHome()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void UcHome_Load(object sender, EventArgs e)
        {
            label1.Text = $"     {DateTime.Now.ToLongTimeString()}";
            CurrentTimeBackgroundWorker.RunWorkerAsync();
        }

        private void CurrentTimeBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            CurrentTimeTimer.Start();
        }

        private void CurrentTimeTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = $"     {DateTime.Now.ToLongTimeString()}";
        }
    }
}
