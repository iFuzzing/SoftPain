using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftPain
{
    public partial class MainForm : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private Form AttachProcessForm = new AttachProcessForm();

        public MainForm()
        {
            InitializeComponent();

            dtgScan.Rows.Add("000000", "0","0");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtManualAddr_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnScan_MouseLeave(object sender, EventArgs e)
        {
            btnScan.Image = Properties.Resources.btnScan;
        }

        private void btnScan_MouseEnter(object sender, EventArgs e)
        {
            btnScan.Image = Properties.Resources.btnScanHover;
        }

        private void btnInject_MouseEnter(object sender, EventArgs e)
        {
            btnInject.Image = Properties.Resources.btnInjectHover;
        }

        private void btnInject_MouseLeave(object sender, EventArgs e)
        {
            btnInject.Image = Properties.Resources.btnInject;
        }

        private void lbAttachProcess_Click(object sender, EventArgs e)
        {
            AttachProcessForm.ShowDialog();

        }

        private void btnAttachProcess_Click(object sender, EventArgs e)
        {
            AttachProcessForm.ShowDialog();
        }
    }
}
