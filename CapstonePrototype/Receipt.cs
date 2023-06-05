using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstonePrototype
{
    public partial class Receipt : Form
    {

        public Receipt(string plateNumber, DateTime timeIn, DateTime timeOut, decimal rate, decimal cash)
        {
            InitializeComponent();
            lbPlateNo.Text = plateNumber;
            lbTimeIn.Text = timeIn.ToString();
            lbTimeOut.Text = timeOut.ToString(); 
            lbRate.Text = rate.ToString("P0.00");
            lbCash.Text = cash.ToString("P0.00");
            lbChange.Text = (cash - rate).ToString("P0.00");
        }


        public Receipt()
        {
            InitializeComponent();
        }

        private void lbPlateNo_Click(object sender, EventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void btPaid_Click(object sender, EventArgs e)
        {//dito tayo mag aadd ng para sa pyhsical receipt
            this.Close();

        }
    }
}
