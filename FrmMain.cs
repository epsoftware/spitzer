using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class FrmMain: Telerik.WinControls.UI.RadForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void radMenuItem_About_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem_LoadData_Click(object sender, EventArgs e)
        {
            FrmLoadReminders myForm = new FrmLoadReminders();
            this.Hide();
            myForm.ShowDialog();
            this.Show();
        }

        private void radMenuItem_Messaging_Click(object sender, EventArgs e)
        {
            FrmLoadReminders myForm = new FrmLoadReminders();
            this.Hide();
            myForm.ShowDialog();
            this.Show();
        }

        private void radMenuItem_Services_Click(object sender, EventArgs e)
        {
            frmMessagesSender myForm = new frmMessagesSender();
            this.Hide();
            myForm.ShowDialog();
            this.Show(); 
        }
    }
}
