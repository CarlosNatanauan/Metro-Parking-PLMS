namespace CapstonePrototype
{
    partial class FRMmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMmain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaMainMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gunaMainExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaBTlog = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBTswitch = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBTlogout = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBTmap = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBTrates = new Guna.UI2.WinForms.Guna2Button();
            this.gunaBTvehicle = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.gunaMainMinimize);
            this.panel1.Controls.Add(this.gunaMainExit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 36);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gunaMainMinimize
            // 
            this.gunaMainMinimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaMainMinimize.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.gunaMainMinimize.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaMainMinimize.Image = ((System.Drawing.Image)(resources.GetObject("gunaMainMinimize.Image")));
            this.gunaMainMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.gunaMainMinimize.ImageRotate = 0F;
            this.gunaMainMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaMainMinimize.Location = new System.Drawing.Point(1259, -4);
            this.gunaMainMinimize.Name = "gunaMainMinimize";
            this.gunaMainMinimize.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaMainMinimize.Size = new System.Drawing.Size(41, 43);
            this.gunaMainMinimize.TabIndex = 9;
            this.gunaMainMinimize.Click += new System.EventHandler(this.gunaMainMinimize_Click);
            // 
            // gunaMainExit
            // 
            this.gunaMainExit.CheckedState.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaMainExit.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.gunaMainExit.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaMainExit.Image = ((System.Drawing.Image)(resources.GetObject("gunaMainExit.Image")));
            this.gunaMainExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.gunaMainExit.ImageRotate = 0F;
            this.gunaMainExit.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaMainExit.Location = new System.Drawing.Point(1315, -4);
            this.gunaMainExit.Name = "gunaMainExit";
            this.gunaMainExit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaMainExit.Size = new System.Drawing.Size(41, 43);
            this.gunaMainExit.TabIndex = 8;
            this.gunaMainExit.Click += new System.EventHandler(this.gunaMainExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "METRO PARKING";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "PLMS |";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(175)))), ((int)(((byte)(159)))));
            this.panel2.Controls.Add(this.gunaBTlog);
            this.panel2.Controls.Add(this.gunaBTswitch);
            this.panel2.Controls.Add(this.gunaBTlogout);
            this.panel2.Controls.Add(this.gunaBTmap);
            this.panel2.Controls.Add(this.gunaBTrates);
            this.panel2.Controls.Add(this.gunaBTvehicle);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 690);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gunaBTlog
            // 
            this.gunaBTlog.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTlog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTlog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBTlog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBTlog.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaBTlog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.gunaBTlog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBTlog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.gunaBTlog.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTlog.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTlog.Image")));
            this.gunaBTlog.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTlog.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTlog.Location = new System.Drawing.Point(0, 349);
            this.gunaBTlog.Name = "gunaBTlog";
            this.gunaBTlog.Size = new System.Drawing.Size(228, 45);
            this.gunaBTlog.TabIndex = 11;
            this.gunaBTlog.Text = "LOG";
            this.gunaBTlog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTlog.Click += new System.EventHandler(this.gunaBTlog_Click);
            // 
            // gunaBTswitch
            // 
            this.gunaBTswitch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTswitch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTswitch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBTswitch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBTswitch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaBTswitch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.gunaBTswitch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBTswitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.gunaBTswitch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(159)))), ((int)(((byte)(77)))));
            this.gunaBTswitch.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTswitch.Image")));
            this.gunaBTswitch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTswitch.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTswitch.Location = new System.Drawing.Point(0, 600);
            this.gunaBTswitch.Name = "gunaBTswitch";
            this.gunaBTswitch.Size = new System.Drawing.Size(228, 45);
            this.gunaBTswitch.TabIndex = 10;
            this.gunaBTswitch.Text = "SWITCH USER";
            this.gunaBTswitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTswitch.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // gunaBTlogout
            // 
            this.gunaBTlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBTlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBTlogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaBTlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.gunaBTlogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBTlogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.gunaBTlogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(110)))), ((int)(((byte)(113)))));
            this.gunaBTlogout.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTlogout.Image")));
            this.gunaBTlogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTlogout.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTlogout.Location = new System.Drawing.Point(0, 645);
            this.gunaBTlogout.Name = "gunaBTlogout";
            this.gunaBTlogout.Size = new System.Drawing.Size(228, 45);
            this.gunaBTlogout.TabIndex = 9;
            this.gunaBTlogout.Text = "LOG OUT";
            this.gunaBTlogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTlogout.Click += new System.EventHandler(this.gunaBTlogout_Click);
            // 
            // gunaBTmap
            // 
            this.gunaBTmap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTmap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTmap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBTmap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBTmap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaBTmap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.gunaBTmap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBTmap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.gunaBTmap.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTmap.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTmap.Image")));
            this.gunaBTmap.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTmap.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTmap.Location = new System.Drawing.Point(0, 304);
            this.gunaBTmap.Name = "gunaBTmap";
            this.gunaBTmap.Size = new System.Drawing.Size(228, 45);
            this.gunaBTmap.TabIndex = 8;
            this.gunaBTmap.Text = "LOT MAP";
            this.gunaBTmap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTmap.Click += new System.EventHandler(this.gunaBTmap_Click);
            // 
            // gunaBTrates
            // 
            this.gunaBTrates.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTrates.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTrates.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBTrates.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBTrates.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaBTrates.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.gunaBTrates.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBTrates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.gunaBTrates.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTrates.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTrates.Image")));
            this.gunaBTrates.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTrates.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTrates.Location = new System.Drawing.Point(0, 259);
            this.gunaBTrates.Name = "gunaBTrates";
            this.gunaBTrates.Size = new System.Drawing.Size(228, 45);
            this.gunaBTrates.TabIndex = 7;
            this.gunaBTrates.Text = "PARKING RATES";
            this.gunaBTrates.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTrates.Click += new System.EventHandler(this.gunaBTrates_Click);
            // 
            // gunaBTvehicle
            // 
            this.gunaBTvehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTvehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaBTvehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaBTvehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaBTvehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaBTvehicle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.gunaBTvehicle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBTvehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(83)))));
            this.gunaBTvehicle.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(184)))));
            this.gunaBTvehicle.Image = ((System.Drawing.Image)(resources.GetObject("gunaBTvehicle.Image")));
            this.gunaBTvehicle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTvehicle.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaBTvehicle.Location = new System.Drawing.Point(0, 214);
            this.gunaBTvehicle.Name = "gunaBTvehicle";
            this.gunaBTvehicle.Size = new System.Drawing.Size(228, 45);
            this.gunaBTvehicle.TabIndex = 6;
            this.gunaBTvehicle.Text = "VEHICLE IN/OUT";
            this.gunaBTvehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gunaBTvehicle.Click += new System.EventHandler(this.gunaBTvehicle_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 214);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Management PH Inc";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(30, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metro Parking™";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(236, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1119, 680);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // FRMmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1370, 726);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMmain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button gunaBTvehicle;
        private Guna.UI2.WinForms.Guna2Button gunaBTrates;
        private Guna.UI2.WinForms.Guna2Button gunaBTmap;
        private Guna.UI2.WinForms.Guna2Button gunaBTlogout;
        private Guna.UI2.WinForms.Guna2Button gunaBTswitch;
        private Guna.UI2.WinForms.Guna2ImageButton gunaMainExit;
        private Guna.UI2.WinForms.Guna2ImageButton gunaMainMinimize;
        private Guna.UI2.WinForms.Guna2Button gunaBTlog;
    }
}

