using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SoftPain.Classes;

namespace SoftPain
{
    public partial class AttachProcessForm : Form
    {

        private const int MAX_PIDLIST = 1024;
        private const int MAX_PNAME = 255;

        [DllImport("lib/penum.dll")]
        public static extern int getProcessIDs(uint[] lpidProcess);

        [DllImport("lib/penum.dll")]
        public static extern int getProcessName(uint pid, StringBuilder sProcessName);


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
        public AttachProcessForm()
        {
            InitializeComponent();



        }

        private void loadProcessList() {
            
            dtgProcessList.Rows.Clear();

            uint[] lpidProcess = new uint[MAX_PIDLIST];
            if (getProcessIDs(lpidProcess) == 0)
            {
                Console.WriteLine("Fail to get processes ids");
                return;
            }

            List<Process> pList = new List<Process>();
            for (int i = 0; i < lpidProcess.Length; i++)
            {
                if (lpidProcess[i] != 0)
                {
                    StringBuilder sProcessName = new StringBuilder(MAX_PNAME);

                    if (getProcessName(lpidProcess[i], sProcessName) != 0)
                    {
                        pList.Add(new Process(sProcessName.ToString(), lpidProcess[i]));
                    }

                }
            }

            for (int i = 0; i < pList.Count; i++)
            {
                Process pProcess = pList[i];
                //Console.WriteLine($"{pProcess.Name}:{pProcess.Pid}");
                dtgProcessList.Rows.Add(pProcess.Pid, pProcess.Name);
            }

            lbProcesListCount.Text = "Nº Process: " + pList.Count;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAttachP_MouseEnter(object sender, EventArgs e)
        {
            btnAttachP.Image = Properties.Resources.btnAttachHover;
        }

        private void btnAttachP_MouseLeave(object sender, EventArgs e)
        {
            btnAttachP.Image = Properties.Resources.btnAttach;
        }

        private void btnAttachP_Click(object sender, EventArgs e)
        {

        }

        private void AttachProcessForm_Load(object sender, EventArgs e)
        {
            loadProcessList();
        }

        private void btnUpdateListProcesses_Click(object sender, EventArgs e)
        {
            loadProcessList();
        }
    }
}
