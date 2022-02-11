using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_PRG281_Music_Game
{
    public partial class Register : Form
    {
         
        public Register()
        {
            InitializeComponent();
        }

        
        void Clear()
        {
            txt_UserNameNew.Text = txt_PasswordNew.Text = txt_PasswordConfirm.Text = "";
        }

       

        private void Register_Load(object sender, EventArgs e)
        {

        }
        // Register button code
        private void btn_Register_Click(object sender, EventArgs e)
        {
            bool isbusy = true;
            while (isbusy)
            {
                try
                {

                }
                catch (Exception)
                {

                    throw;
                }

                if (txt_UserNameNew.Text == "" || txt_PasswordNew.Text == "")
                {
                    MessageBox.Show("Please enter a Username and Password");
                }
                else if (txt_PasswordNew.Text != txt_PasswordConfirm.Text)
                {
                    MessageBox.Show("Passwords do not match");
                }
                else
                {
                    User user = new User(txt_UserNameNew.Text, txt_PasswordNew.Text);
                    User.Adduser(user);
                    
                }
                Close();
            }
        }
    }
}

            // finish button
           /*
            this.Hide();
            Form1 reg2 = new Form1();
            reg2.FormClosed += (s, args) => this.Close();
            reg2.Show();
           */



            
           
