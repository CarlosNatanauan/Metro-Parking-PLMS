using CapstonePrototype.User_Controls;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapstonePrototype
{
    public partial class FRMlogin : Form
    {
        // Fields for sliding icon animation
        private Timer _timer;
        private bool _isTextAdmin;
        private int _iconOffset;

        private bool _isFirstClick = true;

        // Field for storing the icon
        private Bitmap _iconForSwitch;

        // to give the form round edges
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

        [DllImport("user32.dll", EntryPoint = "SetWindowRgn")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);
        // end

        public FRMlogin()
        {
            InitializeComponent();
            InitializeTimer();

            // to give the form round edges
            IntPtr roundRegion = CreateRoundRectRgn(0, 0, Width, Height, 60, 60);
            SetWindowRgn(Handle, roundRegion, true);//end

            UC_InfoAdmin ucad = new UC_InfoAdmin(this);
            addUserControl(ucad);

            // Wire the custom paint event for the GUNA UI button
            btSwitch.Paint += BtSwitch_Paint;
        }

        private void InitializeTimer()
        {
            _timer = new Timer();
            _timer.Interval = 10;
            _timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _iconOffset += 10;
            int iconWidth = _iconForSwitch.Width;

            if (_iconOffset >= btSwitch.Width - iconWidth)
            {
                _timer.Stop();
                _isTextAdmin = !_isTextAdmin;
                _iconOffset = 0;
                btSwitch.Text = _isTextAdmin ? "EMPLOYEE" : "ADMIN";
            }

            btSwitch.Invalidate();
        }

        private void BtSwitch_Paint(object sender, PaintEventArgs e)
        {
            if (_timer.Enabled)
            {
                btSwitch.Text = string.Empty;
            }

            int padding = 5; // Set the desired padding value here

            // Draw the icon
            int iconWidth = _iconForSwitch.Width;
            int iconHeight = _iconForSwitch.Height;
            int iconX = _isTextAdmin ? btSwitch.Width - iconWidth - _iconOffset - padding : _iconOffset + padding;
            int iconY = (btSwitch.Height - iconHeight) / 2;
            e.Graphics.DrawImage(_iconForSwitch, iconX, iconY, iconWidth, iconHeight);
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ShowEmpFormAndClose()
        {
            FRMmain main = new FRMmain();
            main.FormClosed += (s, e) => this.Close();
            main.Show();
            this.Hide();
        }

        public void ShowAdmFormAndClose()
        {
            FRMadminMain main = new FRMadminMain();
            main.FormClosed += (s, e) => this.Close();
            main.Show();
            this.Hide();
        }

        private void FRMlogin_Load(object sender, EventArgs e)
        {
            btSwitch.Text = "ADMIN";
            _iconForSwitch = new Bitmap(@"D:\Documents\Visual Studio Projects\CapstonePrototype\CapstonePrototype\pictures\icForSwitch5.png");
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelUser.Controls.Clear();
            panelUser.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void FRMlogin_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }



        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void btSwitch_Click(object sender, EventArgs e)
        {
            if (_isFirstClick)
            {
                _isFirstClick = false;
            }

            btSwitch.Text = string.Empty;
            _timer.Start();

            // Change the fill color depending on the current state
            if (_isTextAdmin)
            {
                btSwitch.FillColor = ColorTranslator.FromHtml("#7D8995");
                
                UC_InfoAdmin ucad = new UC_InfoAdmin(this);
                addUserControl(ucad);
                
            }
            else
            {
                btSwitch.FillColor = ColorTranslator.FromHtml("#1A73E8"); // Change this to the original fill color
                UC_InfoEmployee ucemp = new UC_InfoEmployee(this);
                addUserControl(ucemp);
            }
        }
    }
}