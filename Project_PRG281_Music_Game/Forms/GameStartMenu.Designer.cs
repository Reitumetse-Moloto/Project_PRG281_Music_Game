
namespace Project_PRG281_Music_Game.Forms
{
    partial class GameStartMenu
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
            this.gbtn_1P = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gbtn_2P = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gbtn_1P
            // 
            this.gbtn_1P.BorderColor = System.Drawing.Color.Transparent;
            this.gbtn_1P.BorderRadius = 10;
            this.gbtn_1P.BorderThickness = 5;
            this.gbtn_1P.CheckedState.Parent = this.gbtn_1P;
            this.gbtn_1P.CustomImages.Parent = this.gbtn_1P;
            this.gbtn_1P.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_1P.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_1P.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_1P.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_1P.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_1P.DisabledState.Parent = this.gbtn_1P;
            this.gbtn_1P.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbtn_1P.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbtn_1P.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_1P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbtn_1P.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gbtn_1P.HoverState.Parent = this.gbtn_1P;
            this.gbtn_1P.Location = new System.Drawing.Point(188, 235);
            this.gbtn_1P.Name = "gbtn_1P";
            this.gbtn_1P.ShadowDecoration.Parent = this.gbtn_1P;
            this.gbtn_1P.Size = new System.Drawing.Size(154, 45);
            this.gbtn_1P.TabIndex = 1;
            this.gbtn_1P.Text = "1-Player";
            this.gbtn_1P.Click += new System.EventHandler(this.gbtn_1P_Click);
            // 
            // gbtn_2P
            // 
            this.gbtn_2P.BorderColor = System.Drawing.Color.Transparent;
            this.gbtn_2P.BorderRadius = 10;
            this.gbtn_2P.BorderThickness = 5;
            this.gbtn_2P.CheckedState.Parent = this.gbtn_2P;
            this.gbtn_2P.CustomImages.Parent = this.gbtn_2P;
            this.gbtn_2P.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_2P.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_2P.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_2P.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_2P.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_2P.DisabledState.Parent = this.gbtn_2P;
            this.gbtn_2P.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbtn_2P.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gbtn_2P.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_2P.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbtn_2P.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gbtn_2P.HoverState.Parent = this.gbtn_2P;
            this.gbtn_2P.Location = new System.Drawing.Point(400, 235);
            this.gbtn_2P.Name = "gbtn_2P";
            this.gbtn_2P.ShadowDecoration.Parent = this.gbtn_2P;
            this.gbtn_2P.Size = new System.Drawing.Size(154, 45);
            this.gbtn_2P.TabIndex = 2;
            this.gbtn_2P.Text = "2-Player";
            this.gbtn_2P.Click += new System.EventHandler(this.gbtn_2P_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(136, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Choose a Game mode";
            // 
            // GameStartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbtn_2P);
            this.Controls.Add(this.gbtn_1P);
            this.Name = "GameStartMenu";
            this.Text = "GameStartMenu";
            this.Load += new System.EventHandler(this.GameStartMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton gbtn_1P;
        private Guna.UI2.WinForms.Guna2GradientButton gbtn_2P;
        private System.Windows.Forms.Label label1;
    }
}