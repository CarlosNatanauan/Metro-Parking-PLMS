﻿namespace CapstonePrototype.User_Controls
{
    partial class UC_InfoAdmin
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
            this.btLoginAd = new Guna.UI2.WinForms.Guna2Button();
            this.tbAdPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAdUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btLoginAd
            // 
            this.btLoginAd.BorderRadius = 10;
            this.btLoginAd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btLoginAd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btLoginAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btLoginAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btLoginAd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.btLoginAd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btLoginAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.btLoginAd.Location = new System.Drawing.Point(167, 194);
            this.btLoginAd.Name = "btLoginAd";
            this.btLoginAd.Size = new System.Drawing.Size(111, 45);
            this.btLoginAd.TabIndex = 24;
            this.btLoginAd.Text = "LOG IN";
            this.btLoginAd.Click += new System.EventHandler(this.btLoginAd_Click);
            // 
            // tbAdPass
            // 
            this.tbAdPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.tbAdPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAdPass.DefaultText = "";
            this.tbAdPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAdPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAdPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAdPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAdPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.tbAdPass.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.tbAdPass.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.tbAdPass.ForeColor = System.Drawing.Color.Gray;
            this.tbAdPass.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.tbAdPass.Location = new System.Drawing.Point(86, 102);
            this.tbAdPass.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.tbAdPass.Name = "tbAdPass";
            this.tbAdPass.PasswordChar = '•';
            this.tbAdPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.tbAdPass.PlaceholderText = "Enter Password";
            this.tbAdPass.SelectedText = "";
            this.tbAdPass.Size = new System.Drawing.Size(279, 43);
            this.tbAdPass.TabIndex = 22;
            this.tbAdPass.TextChanged += new System.EventHandler(this.tbAdPass_TextChanged);
            // 
            // tbAdUser
            // 
            this.tbAdUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.tbAdUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAdUser.DefaultText = "";
            this.tbAdUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAdUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAdUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAdUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAdUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.tbAdUser.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.tbAdUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdUser.ForeColor = System.Drawing.Color.Gray;
            this.tbAdUser.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.tbAdUser.Location = new System.Drawing.Point(86, 49);
            this.tbAdUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAdUser.Name = "tbAdUser";
            this.tbAdUser.PasswordChar = '\0';
            this.tbAdUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.tbAdUser.PlaceholderText = "Enter Username";
            this.tbAdUser.SelectedText = "";
            this.tbAdUser.Size = new System.Drawing.Size(279, 43);
            this.tbAdUser.TabIndex = 23;
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
            this.cbShowPass.TabIndex = 21;
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
            this.lblLogin.Location = new System.Drawing.Point(182, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(85, 30);
            this.lblLogin.TabIndex = 20;
            this.lblLogin.Text = "ADMIN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.panel2.Location = new System.Drawing.Point(86, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 2);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(135)))), ((int)(((byte)(110)))));
            this.panel1.Location = new System.Drawing.Point(86, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 2);
            this.panel1.TabIndex = 18;
            // 
            // UC_InfoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(182)))));
            this.Controls.Add(this.btLoginAd);
            this.Controls.Add(this.tbAdPass);
            this.Controls.Add(this.tbAdUser);
            this.Controls.Add(this.cbShowPass);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_InfoAdmin";
            this.Size = new System.Drawing.Size(449, 254);
            this.Load += new System.EventHandler(this.UC_InfoAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btLoginAd;
        private Guna.UI2.WinForms.Guna2TextBox tbAdPass;
        private Guna.UI2.WinForms.Guna2TextBox tbAdUser;
        private Guna.UI2.WinForms.Guna2CheckBox cbShowPass;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
