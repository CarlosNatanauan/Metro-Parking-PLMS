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
    public partial class FRMlotMap : Form
    {
        public FRMlotMap()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        }

        private void btVehicle_Click(object sender, EventArgs e)
        {

        }

        private void FRMlotMap_Load(object sender, EventArgs e)
        {

        }

        private void gunaBTmapClose_Click(object sender, EventArgs e)
        {
            FRMmain mainForm = (FRMmain)this.Parent.Parent;
            mainForm.CloseActiveForm();
            this.Close();
        }
    }
}
