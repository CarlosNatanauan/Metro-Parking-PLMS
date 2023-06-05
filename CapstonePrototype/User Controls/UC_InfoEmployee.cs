using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CapstonePrototype.User_Controls
{
    public partial class UC_InfoEmployee : UserControl
    {

        private FRMlogin parentForm;
        public UC_InfoEmployee(FRMlogin parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

        }





        private void UC_InfoEmployee_Load(object sender, EventArgs e)
        {

        }



        private void btLoginEmp_Click_1(object sender, EventArgs e)
        {
            string correctUsername = "employee";
            string correctPassword = "emp1";

            // Switch the TextBoxes to compare with the correct values
            if (tbEmpUser.Text == correctUsername && tbEmpPass.Text == correctPassword)
            {
                parentForm.ShowEmpFormAndClose();

            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void tbEmpPass_TextChanged_1(object sender, EventArgs e)
        {


        }



        private void tbEmpUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                tbEmpPass.PasswordChar = '\0'; // Show password
            }
            else
            {
                tbEmpPass.PasswordChar = '●'; // Hide password
            }
        }
    }
}
