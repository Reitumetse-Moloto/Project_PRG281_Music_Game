using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

// Icons resieved at https://icons8.com/

namespace Project_PRG281_Music_Game
{       


    public partial class Login : Form
    {
        private Form activeform;



        public Login()
        {
           
            InitializeComponent();
           
        }

        void Clear()
        {
            txt_UserName.Text = txt_Password.Text = "";
        }

        private void LLBL_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }       
        
        private void gbtn_login_Click(object sender, EventArgs e)
        {
            string usernamei = txt_UserName.Text;
            string passwordi = txt_Password.Text;
            User Myuser = new User();
            Game g = new Game();
            List<User> allUsersinsystem = Myuser.GetUser();
            bool found = false;

            if (usernamei == "" && passwordi == "")
            {
                MessageBox.Show("Please enter your username and password to continue");
            }

            foreach (User userinput in allUsersinsystem)
            {

                if (usernamei == userinput.Username && passwordi == userinput.Password)
                {
                    found = true;
                }

            }

            if (found == true)
            {
                MessageBox.Show("You have successfully logged in");
                

            }
            else
            {
                MessageBox.Show("Please check if Username or Password was spelled correctly");
            }
        }

        private void gbtn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register Reg = new Register();
            Reg.ShowDialog();
        }

        private void gbtn_login_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game();
            game.ShowDialog();
        }
    }
}
