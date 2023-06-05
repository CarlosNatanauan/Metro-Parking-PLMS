using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstonePrototype.User_Controls
{
    public partial class UC_Flatrate : UserControl
    {

        public UC_Flatrate()
        {
            InitializeComponent();
        }

        // Event handler for vehicle check-in button click.
        private void btInMotors_Click(object sender, EventArgs e)
        {
            DateTime timeIn = DateTime.Now;
            string plateNumber = tbplateNoMotors.Text;
            string name = tbNameFlat.Text;

            if (cbVehicleTypeFlat.SelectedItem == null)
            {
                MessageBox.Show("Please select a vehicle type.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string vehicleType = cbVehicleTypeFlat.SelectedItem.ToString();

            DatabaseCodes.InsertPlateNumberFlatrate(plateNumber, name, vehicleType, timeIn);
            dgvFlatrate.DataSource = DatabaseCodes.GetAllPlateNumbersFlatrate();
        }

        // Event handler for search button click.
        private void btSearchMotors_Click(object sender, EventArgs e)
        {
            string searchValue = tbSearchMotors.Text.Trim();

            DataTable dt = DatabaseCodes.GetAllPlateNumbersFlatrate();

            DataRow[] foundRows = dt.Select("PlateNumber = '" + searchValue + "'");

            if (foundRows.Length > 0)
            {
                dgvFlatrate.ClearSelection();
                dgvFlatrate.CurrentCell = dgvFlatrate.Rows[dt.Rows.IndexOf(foundRows[0])].Cells[0];
                dgvFlatrate.Rows[dt.Rows.IndexOf(foundRows[0])].Selected = true;
            }
            else
            {
                MessageBox.Show("The PlateNumber cannot be found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateOccupiedAndAvailableLabels();
        }


        // Event handler for UC_Flatrate load event.
        // Populates the DataGridView with flat rate parking data.
        private void UC_Motors_Load(object sender, EventArgs e)
        {
            dgvFlatrate.DataSource = DatabaseCodes.GetAllPlateNumbersFlatrate();

            foreach (DataGridViewColumn column in dgvFlatrate.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

        // Event handler for copy button click.
        // Copies the plate number to the clipboard.
        private void btnCopyFlatrate_Click(object sender, EventArgs e)
        {
            string textToCopy = tbplateNoMotors.Text;
            if (!string.IsNullOrEmpty(textToCopy))
            {
                Clipboard.SetText(textToCopy);
                MessageBox.Show("Text copied to clipboard!", "Copy Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No text to copy.", "Copy Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Event handler for clear button click.
        // Clears the input fields for flat rate parking.
        private void btbClearFlatrate_Click(object sender, EventArgs e)
        {
            tbplateNoMotors.Text = string.Empty;
            tbNameFlat.Text = string.Empty;
            cbVehicleTypeFlat.SelectedIndex = -1;
        }



        // Updates the selected plate number.
        private void UpdatePlateNumber()
        {
            if (dgvFlatrate.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvFlatrate.SelectedRows[0].Index;
                int plateNumberColumnIndex = 0; // Replace 0 with the actual index of the PlateNumber column in your DataGridView
                string oldPlateNumber = dgvFlatrate.Rows[selectedRowIndex].Cells[plateNumberColumnIndex].Value.ToString();

                using (InputForm inputForm = new InputForm())
                {

                    inputForm.TextBoxInputText = oldPlateNumber;

                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        string newPlateNumber = inputForm.TextBoxInputText;

                        if (!string.IsNullOrEmpty(newPlateNumber) && !newPlateNumber.Equals(oldPlateNumber, StringComparison.InvariantCultureIgnoreCase))
                        {
                            DatabaseCodes.UpdatePlateNumberFlatrate(oldPlateNumber, newPlateNumber);
                            dgvFlatrate.Rows[selectedRowIndex].Cells[plateNumberColumnIndex].Value = newPlateNumber.ToUpper(CultureInfo.InvariantCulture);
                            MessageBox.Show("Plate Number updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Event handler for update plate number button click.
        // Calls the UpdatePlateNumber method.
        private void btUpdate_Click(object sender, EventArgs e)
        {
            UpdatePlateNumber();
        }


        // Event handler for vehicle check-out button click.
        // Updates the database and shows the receipt form for the vehicle.
        private void btOutMotors_Click(object sender, EventArgs e)
        {

            if (dgvFlatrate.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvFlatrate.SelectedRows[0].Index;
                int plateNumberColumnIndex = 0;
                string plateNumber = dgvFlatrate.Rows[selectedRowIndex].Cells[plateNumberColumnIndex].Value.ToString();

                DateTime timeOut = DateTime.Now;

                DatabaseCodes.InsertTimeOutForFlatrate(plateNumber, timeOut);

                dgvFlatrate.DataSource = DatabaseCodes.GetAllPlateNumbersFlatrate();

                // Get required information (name, vehicleType, timeIn, rate)
                string name = dgvFlatrate.Rows[selectedRowIndex].Cells[1].Value.ToString();
                string vehicleType = dgvFlatrate.Rows[selectedRowIndex].Cells[2].Value.ToString();
                DateTime timeIn = DateTime.Parse(dgvFlatrate.Rows[selectedRowIndex].Cells[3].Value.ToString());
                int rate = Convert.ToInt32(dgvFlatrate.Rows[selectedRowIndex].Cells[5].Value);

                using (EnterCash enterCashForm = new EnterCash())
                {
                    if (enterCashForm.ShowDialog() == DialogResult.OK)
                    {
                        decimal cashEntered = enterCashForm.CashEntered;

                        DateTime timeInDateTime = timeIn;
                        DateTime timeOutDateTime = DateTime.Today.Add(timeOut.TimeOfDay);

                        using (Receipt receiptForm = new Receipt(plateNumber, timeInDateTime, timeOutDateTime, rate, cashEntered))
                        {
                            receiptForm.ShowDialog();
                        }


                        DatabaseCodes.InsertFlatrateLog(plateNumber, name, vehicleType, timeIn, timeOut, rate);

                        // Delete the row from Flatrate_raw
                        DatabaseCodes.DeleteFromFlatrateRaw(plateNumber);

                        // Refresh the DataGridView
                        dgvFlatrate.DataSource = DatabaseCodes.GetAllPlateNumbersFlatrate();


                    }
                }
   
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            UpdateOccupiedAndAvailableLabels();

        }


        // Updates the occupied and available parking slot labels.
        private void UpdateOccupiedAndAvailableLabels()
        {
            int totalSlots = 120;

            int occupiedSlotsFlatrate = DatabaseCodes.GetAllPlateNumbersFlatrate().Rows.Count;
            int occupiedSlotsCasual = DatabaseCodes.GetAllPlateNumbersCasual().Rows.Count;
            int occupiedSlots = occupiedSlotsFlatrate + occupiedSlotsCasual;

            int availableSlots = totalSlots - occupiedSlots;

            occupied.Text = $"{occupiedSlots}";
            available.Text = $"{availableSlots}";
        }


        // Event handler for DataGridView data source change.
        // Calls the UpdateOccupiedAndAvailableLabels method.
        private void dgvFlatrate_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateOccupiedAndAvailableLabels();
        }

        private void cbVehicleTypeFlat_Enter(object sender, EventArgs e)
        {
            placeholderLabel.Visible = false;
        }

        private void cbVehicleTypeFlat_Leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2ComboBox ctl = sender as Guna.UI2.WinForms.Guna2ComboBox;
            if (ctl.SelectedIndex == -1)
            {
                placeholderLabel.Visible = true;
            }
        }

        private void cbVehicleTypeFlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2ComboBox ctl = sender as Guna.UI2.WinForms.Guna2ComboBox;
            if (ctl.SelectedIndex == -1)
            {
                placeholderLabel.Visible = true;
            }
            else
            {
                placeholderLabel.Visible = false;
            }
        }
    }
}
