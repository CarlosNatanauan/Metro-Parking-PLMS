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
    public partial class EnterCash : Form
    {

        public decimal CashEntered { get; private set; }
        public bool IsDiscountApplied { get; private set; }
        public bool IsTicketLost { get; private set; }

        public EnterCash()
        {
            InitializeComponent();
        }

        private void tbCash_TextChanged(object sender, EventArgs e)
        {
            decimal.TryParse(tbCash.Text, out decimal cash);
            CashEntered = cash;
        }

        private void tbCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SetCashAndCloseForm();
            }
        }

        private void EnterCash_Load(object sender, EventArgs e)
        {

        }

        private void btPaidEnterCash_Click(object sender, EventArgs e)
        {
            SetCashAndCloseForm();
        }

        private void SetCashAndCloseForm()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RBdiscount_CheckedChanged(object sender, EventArgs e)
        {
            IsDiscountApplied = RBdiscount.Checked;
        }

        private void Tbticket_CheckedChanged(object sender, EventArgs e)
        {
            IsTicketLost = Tbticket.Checked;
        }
    }
}
