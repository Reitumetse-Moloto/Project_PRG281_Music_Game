namespace Project_PRG281_Music_Game
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pn_Login = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbtn_login = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_Register = new Guna.UI2.WinForms.Guna2Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.LBL_Username = new System.Windows.Forms.Label();
            this.pn_Login.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Login
            // 
            this.pn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.pn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pn_Login.Controls.Add(this.panel1);
            this.pn_Login.Location = new System.Drawing.Point(0, 1);
            this.pn_Login.Name = "pn_Login";
            this.pn_Login.Size = new System.Drawing.Size(664, 326);
            this.pn_Login.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.gbtn_login);
            this.panel1.Controls.Add(this.gbtn_Register);
            this.panel1.Controls.Add(this.txt_UserName);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.LBL_Password);
            this.panel1.Controls.Add(this.LBL_Username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 326);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 98);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // gbtn_login
            // 
            this.gbtn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbtn_login.Animated = true;
            this.gbtn_login.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_login.BorderColor = System.Drawing.Color.White;
            this.gbtn_login.BorderRadius = 10;
            this.gbtn_login.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gbtn_login.BorderThickness = 5;
            this.gbtn_login.CheckedState.Parent = this.gbtn_login;
            this.gbtn_login.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbtn_login.CustomImages.Parent = this.gbtn_login;
            this.gbtn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_login.DisabledState.Parent = this.gbtn_login;
            this.gbtn_login.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_login.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_login.ForeColor = System.Drawing.Color.White;
            this.gbtn_login.HoverState.Parent = this.gbtn_login;
            this.gbtn_login.Location = new System.Drawing.Point(476, 279);
            this.gbtn_login.Name = "gbtn_login";
            this.gbtn_login.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbtn_login.ShadowDecoration.Parent = this.gbtn_login;
            this.gbtn_login.Size = new System.Drawing.Size(99, 35);
            this.gbtn_login.TabIndex = 13;
            this.gbtn_login.Text = "Login";
            this.gbtn_login.Click += new System.EventHandler(this.gbtn_login_Click_1);
            // 
            // gbtn_Register
            // 
            this.gbtn_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbtn_Register.Animated = true;
            this.gbtn_Register.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_Register.BorderColor = System.Drawing.Color.White;
            this.gbtn_Register.BorderRadius = 10;
            this.gbtn_Register.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.gbtn_Register.BorderThickness = 2;
            this.gbtn_Register.CheckedState.Parent = this.gbtn_Register;
            this.gbtn_Register.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbtn_Register.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.gbtn_Register.CustomImages.Parent = this.gbtn_Register;
            this.gbtn_Register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Register.DisabledState.Parent = this.gbtn_Register;
            this.gbtn_Register.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_Register.FocusedColor = System.Drawing.Color.Fuchsia;
            this.gbtn_Register.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_Register.ForeColor = System.Drawing.Color.White;
            this.gbtn_Register.HoverState.Parent = this.gbtn_Register;
            this.gbtn_Register.Location = new System.Drawing.Point(581, 288);
            this.gbtn_Register.Name = "gbtn_Register";
            this.gbtn_Register.PressedColor = System.Drawing.Color.Aqua;
            this.gbtn_Register.ShadowDecoration.Parent = this.gbtn_Register;
            this.gbtn_Register.Size = new System.Drawing.Size(71, 26);
            this.gbtn_Register.TabIndex = 12;
            this.gbtn_Register.Text = "Register";
            this.gbtn_Register.UseTransparentBackground = true;
            this.gbtn_Register.Click += new System.EventHandler(this.gbtn_Register_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_UserName.Location = new System.Drawing.Point(284, 145);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.PasswordChar = '*';
            this.txt_UserName.Size = new System.Drawing.Size(153, 20);
            this.txt_UserName.TabIndex = 11;
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Password.Location = new System.Drawing.Point(282, 184);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(153, 20);
            this.txt_Password.TabIndex = 8;
            // 
            // LBL_Password
            // 
            this.LBL_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.LBL_Password.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LBL_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Password.ForeColor = System.Drawing.Color.Gainsboro;
            this.LBL_Password.Location = new System.Drawing.Point(217, 186);
            this.LBL_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(53, 13);
            this.LBL_Password.TabIndex = 10;
            this.LBL_Password.Text = "Password";
            // 
            // LBL_Username
            // 
            this.LBL_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_Username.AutoSize = true;
            this.LBL_Username.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LBL_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Username.ForeColor = System.Drawing.Color.Gainsboro;
            this.LBL_Username.Location = new System.Drawing.Point(217, 145);
            this.LBL_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Username.Name = "LBL_Username";
            this.LBL_Username.Size = new System.Drawing.Size(57, 13);
            this.LBL_Username.TabIndex = 9;
            this.LBL_Username.Text = "UserName";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(664, 327);
            this.Controls.Add(this.pn_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.pn_Login.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_Login;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button gbtn_login;
        private Guna.UI2.WinForms.Guna2Button gbtn_Register;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.Label LBL_Username;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

