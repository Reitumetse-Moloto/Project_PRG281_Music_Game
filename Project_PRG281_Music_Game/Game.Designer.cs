
namespace Project_PRG281_Music_Game
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Back1 = new System.Windows.Forms.Button();
            this.btn_startGame = new System.Windows.Forms.Button();
            this.pn_Logo = new System.Windows.Forms.Panel();
            this.pn_SubForms = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gpn_Header = new Project_PRG281_Music_Game.GradientPanel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_Min = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pn_Menu.SuspendLayout();
            this.pn_SubForms.SuspendLayout();
            this.gpn_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Menu
            // 
            this.pn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.pn_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pn_Menu.Controls.Add(this.btn_Login);
            this.pn_Menu.Controls.Add(this.btn_Back1);
            this.pn_Menu.Controls.Add(this.btn_startGame);
            this.pn_Menu.Controls.Add(this.pn_Logo);
            this.pn_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Menu.Location = new System.Drawing.Point(0, 0);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(105, 494);
            this.pn_Menu.TabIndex = 0;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Login.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.Image")));
            this.btn_Login.Location = new System.Drawing.Point(0, 322);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(105, 73);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Back1
            // 
            this.btn_Back1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Back1.FlatAppearance.BorderSize = 0;
            this.btn_Back1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back1.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Back1.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back1.Image")));
            this.btn_Back1.Location = new System.Drawing.Point(0, 214);
            this.btn_Back1.Name = "btn_Back1";
            this.btn_Back1.Size = new System.Drawing.Size(105, 73);
            this.btn_Back1.TabIndex = 3;
            this.btn_Back1.Text = "Settings";
            this.btn_Back1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Back1.UseVisualStyleBackColor = true;
            this.btn_Back1.Click += new System.EventHandler(this.btn_Settings_Hover);
            // 
            // btn_startGame
            // 
            this.btn_startGame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_startGame.FlatAppearance.BorderSize = 0;
            this.btn_startGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_startGame.Image = ((System.Drawing.Image)(resources.GetObject("btn_startGame.Image")));
            this.btn_startGame.Location = new System.Drawing.Point(0, 110);
            this.btn_startGame.Name = "btn_startGame";
            this.btn_startGame.Size = new System.Drawing.Size(105, 73);
            this.btn_startGame.TabIndex = 1;
            this.btn_startGame.Text = "Play";
            this.btn_startGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_startGame.UseVisualStyleBackColor = true;
            this.btn_startGame.Click += new System.EventHandler(this.btn_startGame_Hover);
            // 
            // pn_Logo
            // 
            this.pn_Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pn_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.pn_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_Logo.BackgroundImage")));
            this.pn_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pn_Logo.Location = new System.Drawing.Point(0, 0);
            this.pn_Logo.Name = "pn_Logo";
            this.pn_Logo.Size = new System.Drawing.Size(105, 104);
            this.pn_Logo.TabIndex = 0;
            // 
            // pn_SubForms
            // 
            this.pn_SubForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pn_SubForms.Controls.Add(this.label1);
            this.pn_SubForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_SubForms.Location = new System.Drawing.Point(105, 91);
            this.pn_SubForms.Name = "pn_SubForms";
            this.pn_SubForms.Size = new System.Drawing.Size(636, 403);
            this.pn_SubForms.TabIndex = 2;
            this.pn_SubForms.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_SubForms_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 203);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Music Game\r\n\r\n Are you up to the challange to test\r\n\r\n your knowle" +
    "dge on music and \r\n\r\nwhat their genre are ";
            // 
            // gpn_Header
            // 
            this.gpn_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(32)))), ((int)(((byte)(47)))));
            this.gpn_Header.ColorBottom = System.Drawing.Color.Transparent;
            this.gpn_Header.ColorTop = System.Drawing.Color.Transparent;
            this.gpn_Header.Controls.Add(this.btn_Home);
            this.gpn_Header.Controls.Add(this.btn_Max);
            this.gpn_Header.Controls.Add(this.btn_Min);
            this.gpn_Header.Controls.Add(this.btn_Exit);
            this.gpn_Header.Controls.Add(this.lbl_Title);
            this.gpn_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpn_Header.Location = new System.Drawing.Point(105, 0);
            this.gpn_Header.Name = "gpn_Header";
            this.gpn_Header.Size = new System.Drawing.Size(636, 91);
            this.gpn_Header.TabIndex = 1;
            this.gpn_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gpn_Header_MouseDown);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Home.BackgroundImage")));
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Location = new System.Drawing.Point(0, -12);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(105, 116);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Max.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Max.BackgroundImage")));
            this.btn_Max.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Max.FlatAppearance.BorderSize = 0;
            this.btn_Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Max.Location = new System.Drawing.Point(576, 0);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(30, 30);
            this.btn_Max.TabIndex = 3;
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_Min
            // 
            this.btn_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Min.BackgroundImage")));
            this.btn_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Min.FlatAppearance.BorderSize = 0;
            this.btn_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Min.Location = new System.Drawing.Point(546, 0);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(30, 30);
            this.btn_Min.TabIndex = 2;
            this.btn_Min.UseVisualStyleBackColor = true;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(606, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(160, 28);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(310, 39);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Music Genre Game";
            this.lbl_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Title_MouseDown);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(741, 494);
            this.Controls.Add(this.pn_SubForms);
            this.Controls.Add(this.gpn_Header);
            this.Controls.Add(this.pn_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.pn_Menu.ResumeLayout(false);
            this.pn_SubForms.ResumeLayout(false);
            this.pn_SubForms.PerformLayout();
            this.gpn_Header.ResumeLayout(false);
            this.gpn_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Menu;
        private System.Windows.Forms.Panel pn_Logo;
        private System.Windows.Forms.Button btn_startGame;
        private System.Windows.Forms.Button btn_Back1;
        private System.Windows.Forms.Button btn_Login;
        private GradientPanel gpn_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pn_SubForms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_Min;
        private System.Windows.Forms.Button btn_Exit;
    }
}