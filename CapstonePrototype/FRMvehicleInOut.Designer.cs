namespace CapstonePrototype
{
    partial class FRMvehicleInOut
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
            this.gunaBTvehicleClose = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btMotor = new Guna.UI2.WinForms.Guna2Button();
            this.btCasual = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(175)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.gunaBTvehicleClose);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 39);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gunaBTvehicleClose
            // 
            this.gunaBTvehicleClose.BorderRadius = 5;
            this.gunaBTvehicleClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaBTvehicleClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTvehicleClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTvehicleClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBTvehicleClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBTvehicleClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.gunaBTvehicleClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gunaBTvehicleClose.ForeColor = System.Drawing.Color.White;
            this.gunaBTvehicleClose.Location = new System.Drawing.Point(1041, 6);
            this.gunaBTvehicleClose.Name = "gunaBTvehicleClose";
            this.gunaBTvehicleClose.Size = new System.Drawing.Size(72, 27);
            this.gunaBTvehicleClose.TabIndex = 0;
            this.gunaBTvehicleClose.Text = "CLOSE";
            this.gunaBTvehicleClose.Click += new System.EventHandler(this.gunaBTvehicleClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "VEHICLE IN/OUT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Consolas", 20F);
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(461, 3);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(179, 32);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "HH:MM:SS:TT";
            this.lbTime.Click += new System.EventHandler(this.lbTime_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btMotor);
            this.panel2.Controls.Add(this.btCasual);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 45);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btMotor
            // 
            this.btMotor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btMotor.Checked = true;
            this.btMotor.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btMotor.CheckedState.FillColor = System.Drawing.Color.White;
            this.btMotor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMotor.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btMotor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btMotor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btMotor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btMotor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btMotor.FillColor = System.Drawing.Color.White;
            this.btMotor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMotor.ForeColor = System.Drawing.Color.Gray;
            this.btMotor.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btMotor.Location = new System.Drawing.Point(0, 4);
            this.btMotor.Name = "btMotor";
            this.btMotor.Size = new System.Drawing.Size(565, 40);
            this.btMotor.TabIndex = 1;
            this.btMotor.Text = "FLATRATE PARKING";
            this.btMotor.Click += new System.EventHandler(this.btMotor_Click);
            // 
            // btCasual
            // 
            this.btCasual.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCasual.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCasual.CheckedState.FillColor = System.Drawing.Color.White;
            this.btCasual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCasual.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btCasual.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCasual.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCasual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCasual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCasual.FillColor = System.Drawing.Color.White;
            this.btCasual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCasual.ForeColor = System.Drawing.Color.Gray;
            this.btCasual.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCasual.Location = new System.Drawing.Point(574, 3);
            this.btCasual.Name = "btCasual";
            this.btCasual.Size = new System.Drawing.Size(565, 40);
            this.btCasual.TabIndex = 0;
            this.btCasual.Text = "CASUAL PARKING";
            this.btCasual.Click += new System.EventHandler(this.btCasual_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 84);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1101, 592);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // FRMvehicleInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1101, 676);
            this.ControlBox = false;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMvehicleInOut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMvehicleInOut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btCasual;
        private Guna.UI2.WinForms.Guna2Button btMotor;
        private Guna.UI2.WinForms.Guna2Button gunaBTvehicleClose;
    }
}