using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Project_PRG281_Music_Game.Forms
{
    public partial class _1_Player : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public _1_Player()
        {
            InitializeComponent();
        }
        private static Timer time;
        
        private void gbtn_Play1_Click_1(object sender, EventArgs e)
        {
            player.URL = "Dynamite.mp3";
        }

        private void gbtn_Stop1_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void gbtn_Submit1_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox7.Checked == true)
            {
                label22.ForeColor = Color.Blue;
                label22.Text = "Correct";
            }
            else
            {
                label22.ForeColor = Color.Red;
                label22.Text = "Incorrect";
            }

            //time.Interval = 3000;
            //tabControl1.SelectTab("Question2");
        }

        private void label22_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {

            }
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox7.Checked = true;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox7.Checked = false;
                checkBox8.Checked = true;
                checkBox9.Checked = false;
            }
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = true;
            }
        }

        //======================================Question 2======================================//

        private void gbtn_Play2_Click_1(object sender, EventArgs e)
        {
            player.URL = "Gettin' Jiggy wit it.mp3";
        }

        private void gbtn_Stop2_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void gbtn_Submit2_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox5.Checked == true)
            {
                label2.ForeColor = Color.Blue;
                label2.Text = "Correct";
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Incorrect";
            }
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {

            }
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox6.Checked = true;
                checkBox5.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox6.Checked = false;
                checkBox5.Checked = true;
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox6.Checked = false;
                checkBox5.Checked = false;
                checkBox4.Checked = true;
            }
        }

        //======================================Question 3======================================//

        private void gbtn_Play3_Click_1(object sender, EventArgs e)
        {
            player.URL = "Harry Styles - Watermelon Sugar .mp3";
        }

        private void gbtn_Stop3_Click_1(object sender, EventArgs e)
        {
            player.URL = "Harry Styles - Watermelon Sugar .mp3";
        }

        private void gbtn_Submit3_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox1.Checked == true)
            {
                label3.ForeColor = Color.Blue;
                label3.Text = "Correct";
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Incorrect";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

            }
        }

        public void checkbox1_click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }
        public void checkbox2_click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
                checkBox3.Checked = false;
            }
        }
        public void checkbox3_click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = true;
            }
        }

        //======================================Question 4======================================//

        private void gbtn_Play4_Click_1(object sender, EventArgs e)
        {
            player.URL = "Hey, Soul Sister.mp3";
        }

        private void gbtn_Stop4_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void gbtn_Submit4_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox12.Checked == true)
            {
                label8.ForeColor = Color.Blue;
                label8.Text = "Correct";
            }
            else
            {
                label8.ForeColor = Color.Red;
                label8.Text = "Incorrect";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

            }
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                checkBox10.Checked = true;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
            }
        }

        private void checkBox11_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                checkBox10.Checked = false;
                checkBox11.Checked = true;
                checkBox12.Checked = false;
            }
        }

        private void checkBox12_Click(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = true;
            }
        }

        //======================================Question 5======================================//

        private void gbtn_Play5_Click_1(object sender, EventArgs e)
        {
            player.URL = "Khalid - Right Back.mp3";
        }

        private void gbtn_Stop5_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void gbtn_Submit5_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox15.Checked == true)
            {
                label9.ForeColor = Color.Blue;
                label9.Text = "Correct";
            }
            else
            {
                label9.ForeColor = Color.Red;
                label9.Text = "Incorrect";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {

            }
        }

        private void checkBox13_Click(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                checkBox13.Checked = true;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
            }
        }

        private void checkBox14_Click(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                checkBox13.Checked = false;
                checkBox14.Checked = true;
                checkBox15.Checked = false;
            }
        }

        private void checkBox15_Click(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = true;
            }
        }

        //======================================Question 6======================================//

        private void gbtn_Play6_Click_1(object sender, EventArgs e)
        {
            player.URL = "Lalala.mp3";
        }

        private void gbtn_Stop6_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void gbtn_Submit6_Click_1(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox18.Checked == true)
            {
                label11.ForeColor = Color.Blue;
                label11.Text = "Correct";
            }
            else
            {
                label11.ForeColor = Color.Red;
                label11.Text = "Incorrect";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {

            }
        }

        private void checkBox18_Click(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                checkBox18.Checked = true;
                checkBox17.Checked = false;
                checkBox16.Checked = false;
            }
        }

        private void checkBox17_Click(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                checkBox18.Checked = false;
                checkBox17.Checked = true;
                checkBox16.Checked = false;
            }
        }

        private void checkBox16_Click(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                checkBox18.Checked = false;
                checkBox17.Checked = false;
                checkBox16.Checked = true;
            }
        }

        //======================================Question 7======================================//

        private void gbtn_Play7_Click(object sender, EventArgs e)
        {
            player.URL = "Remember The Name.mp3";
        }

        private void gbtn_Stop7_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void gbtn_Submit7_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox21.Checked == true)
            {
                label13.ForeColor = Color.Blue;
                label13.Text = "Correct";
            }
            else
            {
                label13.ForeColor = Color.Red;
                label13.Text = "Incorrect";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {

            }
        }

        private void checkBox21_Click(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                checkBox21.Checked = true;
                checkBox20.Checked = false;
                checkBox19.Checked = false;
            }
        }

        private void checkBox20_Click(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                checkBox21.Checked = false;
                checkBox20.Checked = true;
                checkBox19.Checked = false;
            }
        }

        private void checkBox19_Click(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                checkBox21.Checked = false;
                checkBox20.Checked = false;
                checkBox19.Checked = true;
            }
        }

        //======================================Question 8======================================//

        private void gbtn_Play8_Click(object sender, EventArgs e)
        {
            player.URL = "Señorita.mp3";
        }

        private void gbtn_Stop8_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void gbtn_Submit8_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox24.Checked == true)
            {
                label3.ForeColor = Color.Blue;
                label3.Text = "Correct";
            }
            else
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Incorrect";
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            if (checkBox24.Checked == true)
            {

            }
        }

        private void checkBox24_Click(object sender, EventArgs e)
        {
            if (checkBox24.Checked == true)
            {
                checkBox24.Checked = true;
                checkBox23.Checked = false;
                checkBox22.Checked = false;
            }
        }

        private void checkBox23_Click(object sender, EventArgs e)
        {
            if (checkBox23.Checked == true)
            {
                checkBox24.Checked = false;
                checkBox23.Checked = true;
                checkBox22.Checked = false;
            }
        }

        private void checkBox22_Click(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                checkBox24.Checked = false;
                checkBox23.Checked = false;
                checkBox22.Checked = true;
            }
        }

        //======================================Question 9======================================//

        private void gbtn_Play9_Click(object sender, EventArgs e)
        {
            player.URL = "Switch.mp3";
        }

        private void gbtn_Stop9_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void gbtn_Submit9_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox27.Checked == true)
            {
                label17.ForeColor = Color.Blue;
                label17.Text = "Correct";
            }
            else
            {
                label17.ForeColor = Color.Red;
                label17.Text = "Incorrect";
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (checkBox27.Checked == true)
            {

            }
        }

        private void checkBox27_Click(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                checkBox27.Checked = true;
                checkBox26.Checked = false;
                checkBox25.Checked = false;
            }
        }

        private void checkBox26_Click(object sender, EventArgs e)
        {
            if (checkBox26.Checked == true)
            {
                checkBox27.Checked = false;
                checkBox26.Checked = true;
                checkBox25.Checked = false;
            }
        }

        private void checkBox25_Click(object sender, EventArgs e)
        {
            if (checkBox25.Checked == true)
            {
                checkBox27.Checked = false;
                checkBox26.Checked = false;
                checkBox25.Checked = true;
            }
        }

        //======================================Question 10======================================//

        private void gbtn_Play10_Click(object sender, EventArgs e)
        {
            player.URL = "That's What I Like.mp3";
        }

        private void gbtn_Stop10_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void gbtn_Submit10_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox28.Checked == true)
            {
                label19.ForeColor = Color.Blue;
                label19.Text = "Correct";
            }
            else
            {
                label19.ForeColor = Color.Red;
                label19.Text = "Incorrect";
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (checkBox28.Checked == true)
            {

            }
        }

        private void checkBox30_Click(object sender, EventArgs e)
        {
            if (checkBox30.Checked == true)
            {
                checkBox30.Checked = true;
                checkBox29.Checked = false;
                checkBox28.Checked = false;
            }
        }

        private void checkBox29_Click(object sender, EventArgs e)
        {
            if (checkBox29.Checked == true)
            {
                checkBox30.Checked = false;
                checkBox29.Checked = true;
                checkBox28.Checked = false;
            }
        }

        private void checkBox28_Click(object sender, EventArgs e)
        {
            if (checkBox28.Checked == true)
            {
                checkBox30.Checked = false;
                checkBox29.Checked = false;
                checkBox28.Checked = true;
            }
        }

        private void gbtn_Submit10_Click_1(object sender, EventArgs e)
        {
            Player1_Genre Player = new Player1_Genre();
            Player.Show();
        }

        private void _1_Player_Load(object sender, EventArgs e)
        {

        }
    }
}
