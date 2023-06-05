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
    public partial class UC_Flatrate_Log : UserControl
    {
        public UC_Flatrate_Log()
        {
            InitializeComponent();
        }


        public void UpdateDataGridView()
        {
            dgvFlatrateLog.DataSource = DatabaseCodes.GetAllPlateNumbersFlatrateLog();
        }

        private void UC_Flatrate_Log_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
    }
}
