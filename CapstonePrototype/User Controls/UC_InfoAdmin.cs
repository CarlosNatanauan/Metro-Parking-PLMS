using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstonePrototype.User_Controls
{
    public partial class UC_InfoAdmin : UserControl
    {
        private FRMlogin parentForm;
        public UC_InfoAdmin(FRMlogin parentForm)
        {
            InitializeComponent();
            this.parentForm= parentForm;
        }

        private void btLoginAd_Click(object sender, EventArgs e)
        {
            string correctUsername = "admin";
            string correctPassword = "admin";

            if (tbAdPass.Text == correctUsername && tbAdPass.Text == correctPassword)
            {
                parentForm.ShowAdmFormAndClose();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbAdPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_InfoAdmin_Load(object sender, EventArgs e)
        {

        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                tbAdPass.PasswordChar = '\0'; // Show password
            }
            else
            {
                tbAdPass.PasswordChar = '●'; // Hide password
            }
        }
    }
}
