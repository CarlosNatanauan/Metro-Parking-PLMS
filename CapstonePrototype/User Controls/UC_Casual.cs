using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.VisualBasic;

namespace CapstonePrototype.User_Controls
{
    public partial class UC_Casual : UserControl
    {

        public UC_Casual()
        {
            InitializeComponent();

        }

        /// Event handler for UC_Casual load event.
        /// Populates the DataGridView with casual parking data.
        private void UC_Casual_Load(object sender, EventArgs e)
        {
            dgvCasual.DataSource = DatabaseCodes.GetAllPlateNumbersCasual();
            foreach (DataGridViewColumn column in dgvCasual.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        /// Clears the input fields for casual parking.
        private void btbClearCasual_Click(object sender, EventArgs e)
        {
            tbplateNoCasual.Text = string.Empty;
            tbNameCasual.Text = string.Empty;
            cbVehicleTypeCas.SelectedIndex = -1;
        }

        /// Event handler for vehicle check-in button click.
        /// Inserts vehicle details into the database.
        private void btInCasual_Click(object sender, EventArgs e)
        {
            DateTime timeIn = DateTime.Now;
            string plateNumber = tbplateNoCasual.Text;
            string name = tbNameCasual.Text;

            if (cbVehicleTypeCas.SelectedItem == null)
            {
                MessageBox.Show("Please select a vehicle type.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string vehicleType = cbVehicleTypeCas.SelectedItem.ToString();

            DatabaseCodes.InsertPlateNumberCasual(plateNumber, name, vehicleType, timeIn);
            dgvCasual.DataSource = DatabaseCodes.GetAllPlateNumbersCasual();
        }


        /// Event handler for search button click.
        /// Searches for a specific vehicle in the DataGridView based on its plate number.
        private void btSearchCasual_Click(object sender, EventArgs e)
        {
            string searchValue = tbSearchCasual.Text.Trim();

            DataTable dt = DatabaseCodes.GetAllPlateNumbersCasual();

            DataRow[] foundRows = dt.Select("PlateNumber = '" + searchValue + "'");

            if (foundRows.Length > 0)
            {
                dgvCasual.ClearSelection();
                dgvCasual.CurrentCell = dgvCasual.Rows[dt.Rows.IndexOf(foundRows[0])].Cells[0];
                dgvCasual.Rows[dt.Rows.IndexOf(foundRows[0])].Selected = true;
            }
            else
            {
                MessageBox.Show("The PlateNumber cannot be found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateOccupiedAndAvailableLabels();
        }


        /// Event handler for vehicle check-out button click.
        /// Updates the database and shows the receipt form for the vehicle.
        private void btOutCasual_Click(object sender, EventArgs e)
        {

            if (dgvCasual.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvCasual.SelectedRows[0].Index;
                int plateNumberColumnIndex = 0;
                string plateNumber = dgvCasual.Rows[selectedRowIndex].Cells[plateNumberColumnIndex].Value.ToString();

                DateTime timeOut = DateTime.Now;

                // Get required information (name, vehicleType, timeIn, rate)
                string name = dgvCasual.Rows[selectedRowIndex].Cells[1].Value.ToString();
                string vehicleType = dgvCasual.Rows[selectedRowIndex].Cells[2].Value.ToString();
                DateTime timeIn = DateTime.Parse(dgvCasual.Rows[selectedRowIndex].Cells[3].Value.ToString());

                using (EnterCash enterCashForm = new EnterCash())
                {
                    if (enterCashForm.ShowDialog() == DialogResult.OK)
                    {
                        decimal cashEntered = enterCashForm.CashEntered;
                        bool isDiscountApplied = enterCashForm.IsDiscountApplied;
                        bool isTicketLost = enterCashForm.IsTicketLost;

                        DatabaseCodes.InsertTimeOutForCasual(plateNumber, timeOut, isDiscountApplied, isTicketLost);

                        dgvCasual.DataSource = DatabaseCodes.GetAllPlateNumbersCasual();

                        int rate = Convert.ToInt32(dgvCasual.Rows[selectedRowIndex].Cells[5].Value);

                        DateTime timeInDateTime = timeIn;
                        DateTime timeOutDateTime = DateTime.Today.Add(timeOut.TimeOfDay);

                        using (Receipt receiptForm = new Receipt(plateNumber, timeInDateTime, timeOutDateTime, rate, cashEntered))
                        {
                            receiptForm.ShowDialog();
                        }

                        DatabaseCodes.InsertCasualLog(plateNumber, name, vehicleType, timeIn, timeOut, rate);

                        // Delete the row from Flatrate_raw
                        DatabaseCodes.DeleteFromCasualRaw(plateNumber);

                        // Refresh the DataGridView
                        dgvCasual.DataSource = DatabaseCodes.GetAllPlateNumbersCasual();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateOccupiedAndAvailableLabels();
        }


        /// Updates the selected plate number.
        private void UpdatePlateNumber()
        {
            if (dgvCasual.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvCasual.SelectedRows[0].Index;
                int plateNumberColumnIndex = 0;
                string oldPlateNumber = dgvCasual.Rows[selectedRowIndex].Cells[plateNumberColumnIndex].Value.ToString();

                using (InputForm inputForm = new InputForm())
                {

                    inputForm.TextBoxInputText = oldPlateNumber;

                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        string newPlateNumber = inputForm.TextBoxInputText;

                        if (!string.IsNullOrEmpty(newPlateNumber) && !newPlateNumber.Equals(oldPlateNumber, StringComparison.InvariantCultureIgnoreCase))
                        {
                            DatabaseCodes.UpdatePlateNumberCasual(oldPlateNumber, newPlateNumber);
                            dgvCasual.Rows[selectedRowIndex].Cells[plateNumberColumnIndex].Value = newPlateNumber.ToUpper(CultureInfo.InvariantCulture);
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


        /// Event handler for update plate number button click.
        /// Calls the UpdatePlateNumber method.
        private void btUpdateCasual_Click(object sender, EventArgs e)
        {
            UpdatePlateNumber();
        }


        /// Updates the occupied and available parking slot labels.
        private void UpdateOccupiedAndAvailableLabels()
        {
            int totalSlots = 120;

            int occupiedSlotsFlatrate = DatabaseCodes.GetAllPlateNumbersFlatrate().Rows.Count;
            int occupiedSlotsCasual = DatabaseCodes.GetAllPlateNumbersCasual().Rows.Count;
            int occupiedSlots = occupiedSlotsFlatrate + occupiedSlotsCasual;

            int availableSlots = totalSlots - occupiedSlots;

            occupiedCasual.Text = $"{occupiedSlots}";
            availableCasual.Text = $"{availableSlots}";
        }

        /// Event handler for DataGridView data source change.
        /// Calls the UpdateOccupiedAndAvailableLabels method.
        private void dgvCasual_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateOccupiedAndAvailableLabels();
        }

        /// Event handler for copy button click.
        /// Copies the plate number to the clipboard.
        private void btnCopyCasual_Click_1(object sender, EventArgs e)
        {
            string textToCopy = tbplateNoCasual.Text;
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



        //for placeholder on combo box (vehicle type)
        private void cbVehicleTypeCas_Enter(object sender, EventArgs e)
        {
            placeholderLabel.Visible = false;
        }

        private void cbVehicleTypeCas_Leave(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2ComboBox ctl = sender as Guna.UI2.WinForms.Guna2ComboBox;
            if (ctl.SelectedIndex == -1)
            {
                placeholderLabel.Visible = true;
            }
        }

        private void cbVehicleTypeCas_SelectedIndexChanged(object sender, EventArgs e)
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
