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

namespace CapstonePrototype
{
    public partial class FRMmain : Form
    {
        private Form activeForm = null;

        public FRMmain()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            
        
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int y = Screen.PrimaryScreen.Bounds.Height;
            int x = Screen.PrimaryScreen.Bounds.Width;
            this.Height = y - 40;
            this.Width = x;
            this.Top = 0;
            this.Left = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        public void CloseActiveForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }










        private void btMainMinimize_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btMainExit_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaBTvehicle_Click(object sender, EventArgs e)
        {
            FRMvehicleInOut f = new FRMvehicleInOut();
            openChildForm(f);
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void gunaBTrates_Click(object sender, EventArgs e)
        {
            FRMparkingRates f = new FRMparkingRates();
            openChildForm(f);
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void gunaBTlog_Click(object sender, EventArgs e)
        {
            FRMlog f = new FRMlog();
            openChildForm(f);
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void gunaBTmap_Click(object sender, EventArgs e)
        {
           
            FRMlotMap f = new FRMlotMap();
            openChildForm(f);
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {//this is switch button

        }

        private void gunaBTlogout_Click(object sender, EventArgs e)
        {

        }

        private void gunaMainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaMainMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
