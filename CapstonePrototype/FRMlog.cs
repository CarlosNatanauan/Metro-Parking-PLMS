using CapstonePrototype.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CapstonePrototype
{
    public partial class FRMlog : Form
    {
        public FRMlog()
        {
            InitializeComponent();
            UC_Flatrate_Log defaults = new UC_Flatrate_Log();
            addUserControl(defaults);
        }

        /*
        public void UpdateDataGridView()
        {
            dgvFlatrateLog.DataSource = DatabaseCodes.GetAllPlateNumbersFlatrateLog();
        }
        */

        private void FRMlog_Load(object sender, EventArgs e)
        {


            LbDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");


        }




        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btMotorLog_Click(object sender, EventArgs e)
        {
            UC_Flatrate_Log uc = new UC_Flatrate_Log();
            addUserControl(uc);
        }

        private void btCasualLog_Click(object sender, EventArgs e)
        {
            UC_CasualLog uc = new UC_CasualLog();
            addUserControl(uc);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
        }

        private void gunaBTlog_Click(object sender, EventArgs e)
        {
            FRMmain mainForm = (FRMmain)this.Parent.Parent;
            mainForm.CloseActiveForm();
            this.Close();
        }
    }
}
