
namespace Project_PRG281_Music_Game.Forms
{
    partial class Settings
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
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.btn_Changemusicorturnoff = new System.Windows.Forms.Button();
            this.btn_Account_Settings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Menu
            // 
            this.pn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.pn_Menu.Controls.Add(this.btn_Changemusicorturnoff);
            this.pn_Menu.Controls.Add(this.btn_Account_Settings);
            this.pn_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Menu.Location = new System.Drawing.Point(0, 0);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(800, 59);
            this.pn_Menu.TabIndex = 0;
            // 
            // btn_Changemusicorturnoff
            // 
            this.btn_Changemusicorturnoff.FlatAppearance.BorderSize = 0;
            this.btn_Changemusicorturnoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Changemusicorturnoff.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Changemusicorturnoff.Location = new System.Drawing.Point(111, 3);
            this.btn_Changemusicorturnoff.Name = "btn_Changemusicorturnoff";
            this.btn_Changemusicorturnoff.Size = new System.Drawing.Size(105, 53);
            this.btn_Changemusicorturnoff.TabIndex = 2;
            this.btn_Changemusicorturnoff.Text = "Menu Music";
            this.btn_Changemusicorturnoff.UseVisualStyleBackColor = true;
            // 
            // btn_Account_Settings
            // 
            this.btn_Account_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Account_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account_Settings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Account_Settings.Location = new System.Drawing.Point(3, 3);
            this.btn_Account_Settings.Name = "btn_Account_Settings";
            this.btn_Account_Settings.Size = new System.Drawing.Size(105, 53);
            this.btn_Account_Settings.TabIndex = 1;
            this.btn_Account_Settings.Text = "Account";
            this.btn_Account_Settings.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 391);
            this.panel1.TabIndex = 1;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_Menu);
            this.Name = "Settings";
            this.Text = "Settings";
            this.pn_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Menu;
        private System.Windows.Forms.Button btn_Changemusicorturnoff;
        private System.Windows.Forms.Button btn_Account_Settings;
        private System.Windows.Forms.Panel panel1;
    }
}