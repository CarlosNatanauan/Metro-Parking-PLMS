namespace CapstonePrototype
{
    partial class FRMlog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbDate = new System.Windows.Forms.Label();
            this.gunaBTlog = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.prototypeDataSet4 = new CapstonePrototype.prototypeDataSet4();
            this.prototypeDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prototypeDataSet5 = new CapstonePrototype.prototypeDataSet5();
            this.flatratelogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flatrate_logTableAdapter = new CapstonePrototype.prototypeDataSet5TableAdapters.Flatrate_logTableAdapter();
            this.flatratelogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prototypeDataSet6 = new CapstonePrototype.prototypeDataSet6();
            this.flatrate_logTableAdapter1 = new CapstonePrototype.prototypeDataSet6TableAdapters.Flatrate_logTableAdapter();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btMotorLog = new Guna.UI2.WinForms.Guna2Button();
            this.btCasualLog = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet6)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(175)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.LbDate);
            this.panel1.Controls.Add(this.gunaBTlog);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 41);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.Font = new System.Drawing.Font("Consolas", 20F);
            this.LbDate.ForeColor = System.Drawing.Color.White;
            this.LbDate.Location = new System.Drawing.Point(408, 4);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(284, 32);
            this.LbDate.TabIndex = 9;
            this.LbDate.Text = "dddd, MMMM d, yyyy";
            // 
            // gunaBTlog
            // 
            this.gunaBTlog.BorderRadius = 5;
            this.gunaBTlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaBTlog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTlog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTlog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBTlog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBTlog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.gunaBTlog.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gunaBTlog.ForeColor = System.Drawing.Color.White;
            this.gunaBTlog.Location = new System.Drawing.Point(1041, 6);
            this.gunaBTlog.Name = "gunaBTlog";
            this.gunaBTlog.Size = new System.Drawing.Size(72, 27);
            this.gunaBTlog.TabIndex = 8;
            this.gunaBTlog.Text = "CLOSE";
            this.gunaBTlog.Click += new System.EventHandler(this.gunaBTlog_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "VEHICLE LOG";
            // 
            // prototypeDataSet4
            // 
            this.prototypeDataSet4.DataSetName = "prototypeDataSet4";
            this.prototypeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prototypeDataSet4BindingSource
            // 
            this.prototypeDataSet4BindingSource.DataSource = this.prototypeDataSet4;
            this.prototypeDataSet4BindingSource.Position = 0;
            // 
            // prototypeDataSet5
            // 
            this.prototypeDataSet5.DataSetName = "prototypeDataSet5";
            this.prototypeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flatratelogBindingSource
            // 
            this.flatratelogBindingSource.DataMember = "Flatrate_log";
            this.flatratelogBindingSource.DataSource = this.prototypeDataSet5;
            // 
            // flatrate_logTableAdapter
            // 
            this.flatrate_logTableAdapter.ClearBeforeFill = true;
            // 
            // flatratelogBindingSource1
            // 
            this.flatratelogBindingSource1.DataMember = "Flatrate_log";
            this.flatratelogBindingSource1.DataSource = this.prototypeDataSet6;
            // 
            // prototypeDataSet6
            // 
            this.prototypeDataSet6.DataSetName = "prototypeDataSet6";
            this.prototypeDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flatrate_logTableAdapter1
            // 
            this.flatrate_logTableAdapter1.ClearBeforeFill = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btMotorLog);
            this.guna2Panel1.Controls.Add(this.btCasualLog);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 41);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1101, 45);
            this.guna2Panel1.TabIndex = 37;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btMotorLog
            // 
            this.btMotorLog.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btMotorLog.Checked = true;
            this.btMotorLog.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btMotorLog.CheckedState.FillColor = System.Drawing.Color.White;
            this.btMotorLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMotorLog.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btMotorLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMotorLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMotorLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMotorLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMotorLog.FillColor = System.Drawing.Color.White;
            this.btMotorLog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMotorLog.ForeColor = System.Drawing.Color.Gray;
            this.btMotorLog.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btMotorLog.Location = new System.Drawing.Point(0, 4);
            this.btMotorLog.Name = "btMotorLog";
            this.btMotorLog.Size = new System.Drawing.Size(565, 40);
            this.btMotorLog.TabIndex = 3;
            this.btMotorLog.Text = "FLATRATE LOG";
            this.btMotorLog.Click += new System.EventHandler(this.btMotorLog_Click);
            // 
            // btCasualLog
            // 
            this.btCasualLog.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCasualLog.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCasualLog.CheckedState.FillColor = System.Drawing.Color.White;
            this.btCasualLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCasualLog.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btCasualLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCasualLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCasualLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCasualLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCasualLog.FillColor = System.Drawing.Color.White;
            this.btCasualLog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCasualLog.ForeColor = System.Drawing.Color.Gray;
            this.btCasualLog.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCasualLog.Location = new System.Drawing.Point(574, 3);
            this.btCasualLog.Name = "btCasualLog";
            this.btCasualLog.Size = new System.Drawing.Size(565, 40);
            this.btCasualLog.TabIndex = 2;
            this.btCasualLog.Text = "CASUAL LOG";
            this.btCasualLog.Click += new System.EventHandler(this.btCasualLog_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 86);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1101, 590);
            this.panelContainer.TabIndex = 38;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRMlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 676);
            this.ControlBox = false;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FRMlog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMlog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatratelogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototypeDataSet6)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button gunaBTlog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource prototypeDataSet4BindingSource;
        private prototypeDataSet4 prototypeDataSet4;
        private prototypeDataSet5 prototypeDataSet5;
        private System.Windows.Forms.BindingSource flatratelogBindingSource;
        private prototypeDataSet5TableAdapters.Flatrate_logTableAdapter flatrate_logTableAdapter;
        private prototypeDataSet6 prototypeDataSet6;
        private System.Windows.Forms.BindingSource flatratelogBindingSource1;
        private prototypeDataSet6TableAdapters.Flatrate_logTableAdapter flatrate_logTableAdapter1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btMotorLog;
        private Guna.UI2.WinForms.Guna2Button btCasualLog;
        private Guna.UI2.WinForms.Guna2Panel panelContainer;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.Timer timer1;
    }
}