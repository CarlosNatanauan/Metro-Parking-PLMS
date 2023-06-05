namespace CapstonePrototype.User_Controls
{
    partial class UC_CasualLog
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flatratelogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prototypeDataSet7 = new CapstonePrototype.prototypeDataSet7();
            this.label1 = new System.Windows.Forms.Label();
            this.flatrate_logTableAdapter = new CapstonePrototype.prototypeDataSet7TableAdapters.Flatrate_logTableAdapter();
            this.prototypeDataSet11 = new CapstonePrototype.prototypeDataSet11();
            this.casuallogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casual_logTableAdapter = new CapstonePrototype.prototypeDataSet11TableAdapters.Casual_logTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCasualLog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.plateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casuallogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prototypeDataSet12 = new CapstonePrototype.prototypeDataSet12();
            this.casual_logTableAdapter1 = new CapstonePrototype.prototypeDataSet12TableAdapters.Casual_logTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casuallogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasualLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casuallogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // flatratelogBindingSource
            // 
            this.flatratelogBindingSource.DataMember = "Flatrate_log";
            this.flatratelogBindingSource.DataSource = this.prototypeDataSet7;
            // 
            // prototypeDataSet7
            // 
            this.prototypeDataSet7.DataSetName = "prototypeDataSet7";
            this.prototypeDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Successfully Exited Vehicles";
            // 
            // flatrate_logTableAdapter
            // 
            this.flatrate_logTableAdapter.ClearBeforeFill = true;
            // 
            // prototypeDataSet11
            // 
            this.prototypeDataSet11.DataSetName = "prototypeDataSet11";
            this.prototypeDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // casuallogBindingSource
            // 
            this.casuallogBindingSource.DataMember = "Casual_log";
            this.casuallogBindingSource.DataSource = this.prototypeDataSet11;
            // 
            // casual_logTableAdapter
            // 
            this.casual_logTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(1268, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 31);
            this.label2.TabIndex = 42;
            this.label2.Text = "Successfully Exited Vehicles";
            // 
            // dgvCasualLog
            // 
            this.dgvCasualLog.AllowUserToAddRows = false;
            this.dgvCasualLog.AllowUserToDeleteRows = false;
            this.dgvCasualLog.AllowUserToResizeColumns = false;
            this.dgvCasualLog.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCasualLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCasualLog.AutoGenerateColumns = false;
            this.dgvCasualLog.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCasualLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(175)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(217)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCasualLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCasualLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plateNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn});
            this.dgvCasualLog.DataSource = this.casuallogBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCasualLog.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCasualLog.GridColor = System.Drawing.Color.White;
            this.dgvCasualLog.Location = new System.Drawing.Point(9, 67);
            this.dgvCasualLog.Name = "dgvCasualLog";
            this.dgvCasualLog.ReadOnly = true;
            this.dgvCasualLog.RowHeadersVisible = false;
            this.dgvCasualLog.Size = new System.Drawing.Size(1089, 504);
            this.dgvCasualLog.TabIndex = 43;
            this.dgvCasualLog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCasualLog.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCasualLog.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCasualLog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCasualLog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCasualLog.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvCasualLog.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvCasualLog.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvCasualLog.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCasualLog.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCasualLog.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCasualLog.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCasualLog.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvCasualLog.ThemeStyle.ReadOnly = true;
            this.dgvCasualLog.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCasualLog.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCasualLog.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCasualLog.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCasualLog.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCasualLog.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCasualLog.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // plateNumberDataGridViewTextBoxColumn
            // 
            this.plateNumberDataGridViewTextBoxColumn.DataPropertyName = "plateNumber";
            this.plateNumberDataGridViewTextBoxColumn.HeaderText = "   PLATE NUMBER";
            this.plateNumberDataGridViewTextBoxColumn.Name = "plateNumberDataGridViewTextBoxColumn";
            this.plateNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "     DRIVER\'S NAME";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "vehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "     VEHICLE TYPE";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            this.timeInDataGridViewTextBoxColumn.DataPropertyName = "timeIn";
            this.timeInDataGridViewTextBoxColumn.HeaderText = "    TIME IN";
            this.timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            this.timeInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "timeOut";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "    TIME OUT";
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            this.timeOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "     RATE";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // casuallogBindingSource1
            // 
            this.casuallogBindingSource1.DataMember = "Casual_log";
            this.casuallogBindingSource1.DataSource = this.prototypeDataSet12;
            // 
            // prototypeDataSet12
            // 
            this.prototypeDataSet12.DataSetName = "prototypeDataSet12";
            this.prototypeDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // casual_logTableAdapter1
            // 
            this.casual_logTableAdapter1.ClearBeforeFill = true;
            // 
            // UC_CasualLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCasualLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_CasualLog";
            this.Size = new System.Drawing.Size(1101, 599);
            this.Load += new System.EventHandler(this.UC_CasualLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casuallogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasualLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casuallogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource flatratelogBindingSource;
        private prototypeDataSet7 prototypeDataSet7;
        private System.Windows.Forms.Label label1;
        private prototypeDataSet7TableAdapters.Flatrate_logTableAdapter flatrate_logTableAdapter;
        private System.Windows.Forms.BindingSource casuallogBindingSource;
        private prototypeDataSet11 prototypeDataSet11;
        private prototypeDataSet11TableAdapters.Casual_logTableAdapter casual_logTableAdapter;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCasualLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource casuallogBindingSource1;
        private prototypeDataSet12 prototypeDataSet12;
        private prototypeDataSet12TableAdapters.Casual_logTableAdapter casual_logTableAdapter1;
    }
}
