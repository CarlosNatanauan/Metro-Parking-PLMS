namespace CapstonePrototype.User_Controls
{
    partial class UC_InfoEmployee
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
            this.cbShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbEmpUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.btLoginEmp = new Guna.UI2.WinForms.Guna2Button();
            this.tbEmpPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShowPass.CheckedState.BorderRadius = 0;
            this.cbShowPass.CheckedState.BorderThickness = 0;
            this.cbShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbShowPass.ForeColor = System.Drawing.Color.Gray;
            this.cbShowPass.Location = new System.Drawing.Point(83, 168);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(101, 17);
            this.cbShowPass.TabIndex = 14;
            this.cbShowPass.Text = "Show password";
            this.cbShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbShowPass.UncheckedState.BorderRadius = 0;
            this.cbShowPass.UncheckedState.BorderThickness = 0;
            this.cbShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Gray;
            this.lblLogin.Location = new System.Drawing.Point(164, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(120, 30);
            this.lblLogin.TabIndex = 13;
            this.lblLogin.Text = "EMPLOYEE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.panel2.Location = new System.Drawing.Point(86, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 2);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.panel1.Location = new System.Drawing.Point(86, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 2);
            this.panel1.TabIndex = 11;
            // 
            // tbEmpUser
            // 
            this.tbEmpUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.tbEmpUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmpUser.DefaultText = "";
            this.tbEmpUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmpUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmpUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmpUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmpUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.tbEmpUser.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.tbEmpUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpUser.ForeColor = System.Drawing.Color.Gray;
            this.tbEmpUser.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.tbEmpUser.Location = new System.Drawing.Point(86, 49);
            this.tbEmpUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmpUser.Name = "tbEmpUser";
            this.tbEmpUser.PasswordChar = '\0';
            this.tbEmpUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.tbEmpUser.PlaceholderText = "Enter Username";
            this.tbEmpUser.SelectedText = "";
            this.tbEmpUser.Size = new System.Drawing.Size(279, 43);
            this.tbEmpUser.TabIndex = 16;
            this.tbEmpUser.TextChanged += new System.EventHandler(this.tbEmpUser_TextChanged);
            // 
            // btLoginEmp
            // 
            this.btLoginEmp.BorderRadius = 10;
            this.btLoginEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btLoginEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btLoginEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btLoginEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btLoginEmp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.btLoginEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoginEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.btLoginEmp.Location = new System.Drawing.Point(167, 194);
            this.btLoginEmp.Name = "btLoginEmp";
            this.btLoginEmp.Size = new System.Drawing.Size(111, 45);
            this.btLoginEmp.TabIndex = 17;
            this.btLoginEmp.Text = "LOG IN";
            this.btLoginEmp.Click += new System.EventHandler(this.btLoginEmp_Click_1);
            // 
            // tbEmpPass
            // 
            this.tbEmpPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.tbEmpPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmpPass.DefaultText = "";
            this.tbEmpPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmpPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmpPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmpPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmpPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.tbEmpPass.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.tbEmpPass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbEmpPass.ForeColor = System.Drawing.Color.Gray;
            this.tbEmpPass.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.tbEmpPass.Location = new System.Drawing.Point(86, 102);
            this.tbEmpPass.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.tbEmpPass.Name = "tbEmpPass";
            this.tbEmpPass.PasswordChar = '•';
            this.tbEmpPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.tbEmpPass.PlaceholderText = "Enter Password";
            this.tbEmpPass.SelectedText = "";
            this.tbEmpPass.Size = new System.Drawing.Size(279, 43);
            this.tbEmpPass.TabIndex = 16;
            this.tbEmpPass.TextChanged += new System.EventHandler(this.tbEmpPass_TextChanged_1);
            // 
            // UC_InfoEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.Controls.Add(this.btLoginEmp);
            this.Controls.Add(this.tbEmpPass);
            this.Controls.Add(this.tbEmpUser);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_InfoEmployee";
            this.Size = new System.Drawing.Size(449, 254);
            this.Load += new System.EventHandler(this.UC_InfoEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CheckBox cbShowPass;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbEmpUser;
        private Guna.UI2.WinForms.Guna2Button btLoginEmp;
        private Guna.UI2.WinForms.Guna2TextBox tbEmpPass;
    }
}
