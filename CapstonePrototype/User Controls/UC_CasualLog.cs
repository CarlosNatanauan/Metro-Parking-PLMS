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
    public partial class UC_CasualLog : UserControl
    {
        public UC_CasualLog()
        {
            InitializeComponent();
        }


        public void UpdateDataGridView()
        {
            dgvCasualLog.DataSource = DatabaseCodes.GetAllPlateNumbersCasualLog();
        }

        private void UC_CasualLog_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
    }
}
