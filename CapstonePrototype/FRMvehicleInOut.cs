using CapstonePrototype.User_Controls;
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
    public partial class FRMvehicleInOut : Form
    {
        //to make accecible to other form
        public Label GetCurrentTimeLabel()
        {
            return lbTime;
        }


        public FRMvehicleInOut()
        {

            InitializeComponent();
            UC_Flatrate ucM = new UC_Flatrate();
            addUserControl(ucM);
            //UC_Casual uc = new UC_Casual();
            //addUserControl(uc);

        }

        //This is just to make the button round
        public static class ButtonUtils
        {
            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );

            public static void SetRoundButton(Button button, int radius)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                Region region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width, button.Height, radius, radius));
                button.Region = region;
            }
        }
        //This is just to make the button round




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void FRMvehicleInOut_Load(object sender, EventArgs e)
        {
            
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
           
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void LbDate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btVehicleClose_MouseHover(object sender, EventArgs e)
        {
            //btVehicleClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btVehicleClose_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void addUserControl(UserControl userControl) 
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }



        private void btCasual_Click(object sender, EventArgs e)
        {
            UC_Casual uc = new UC_Casual();
            addUserControl(uc);
        }

        private void btMotor_Click(object sender, EventArgs e)
        {
            UC_Flatrate uc = new UC_Flatrate();
            addUserControl(uc);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        public void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void gunaBTvehicleClose_Click(object sender, EventArgs e)
        {
            FRMmain mainForm = (FRMmain)this.Parent.Parent;
            mainForm.CloseActiveForm();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
