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
    
    public partial class _2_Player : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public _2_Player()
        {
            InitializeComponent();
        }

        //======================================Question 1======================================//

        private void button30_Click(object sender, EventArgs e)
        {
            player.URL = "Dynamite.mp3";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox28.Checked == true && radioButton28.Checked == true)
            {
                label19.ForeColor = Color.Blue;
                label19.Text = "Correct";
                label20.ForeColor = Color.Blue;
                label20.Text = "Correct";
            }
            else
            {
                label19.ForeColor = Color.Red;
                label19.Text = "Incorrect";
                label20.ForeColor = Color.Red;
                label20.Text = "Incorrect";
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            if (checkBox28.Checked == true)
            {

            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            if (radioButton28.Checked == true)
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

        private void radioButton30_Click(object sender, EventArgs e)
        {
            if (radioButton30.Checked == true)
            {
                radioButton30.Checked = true;
                radioButton29.Checked = false;
                radioButton28.Checked = false;
            }
        }

        private void radioButton29_Click(object sender, EventArgs e)
        {
            if (radioButton29.Checked == true)
            {
                radioButton30.Checked = false;
                radioButton29.Checked = true;
                radioButton28.Checked = false;
            }
        }

        private void radioButton28_Click(object sender, EventArgs e)
        {
            if (radioButton28.Checked == true)
            {
                radioButton30.Checked = false;
                radioButton29.Checked = false;
                radioButton28.Checked = true;
            }
        }

        //======================================Question 2======================================//

        private void button6_Click(object sender, EventArgs e)
        {
            player.URL = "Gettin' Jiggy Wit It";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox6.Checked == true && radioButton6.Checked == true)
            {
                label14.ForeColor = Color.Blue;
                label14.Text = "Correct";
                label13.ForeColor = Color.Blue;
                label13.Text = "Correct";
            }
            else
            {
                label14.ForeColor = Color.Red;
                label14.Text = "Incorrect";
                label13.ForeColor = Color.Red;
                label13.Text = "Incorrect";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
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

        private void radioButton6_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                radioButton6.Checked = true;
                radioButton5.Checked = false;
                radioButton4.Checked = false;
            }
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                radioButton6.Checked = false;
                radioButton5.Checked = true;
                radioButton4.Checked = false;
            }
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                radioButton6.Checked = false;
                radioButton5.Checked = false;
                radioButton4.Checked = true;
            }
        }

        //======================================Question 3======================================//

        private void button9_Click(object sender, EventArgs e)
        {
            player.URL = "Harry Styles - Watermelon Sugar .mp3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox9.Checked == true && radioButton9.Checked == true)
            {
                label5.ForeColor = Color.Blue;
                label5.Text = "Correct";
                label6.ForeColor = Color.Blue;
                label6.Text = "Correct";
            }
            else
            {
                label5.ForeColor = Color.Red;
                label5.Text = "Incorrect";
                label6.ForeColor = Color.Red;
                label6.Text = "Incorrect";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {

            }
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                checkBox9.Checked = true;
                checkBox8.Checked = false;
                checkBox7.Checked = false;
            }
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox9.Checked = false;
                checkBox8.Checked = true;
                checkBox7.Checked = false;
            }
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox9.Checked = false;
                checkBox8.Checked = false;
                checkBox7.Checked = true;
            }
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                radioButton9.Checked = true;
                radioButton8.Checked = false;
                radioButton7.Checked = false;
            }
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                radioButton9.Checked = false;
                radioButton8.Checked = true;
                radioButton7.Checked = false;
            }
        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                radioButton9.Checked = false;
                radioButton8.Checked = false;
                radioButton7.Checked = true;
            }
        }

        //======================================Question 4======================================//

        private void button12_Click(object sender, EventArgs e)
        {
            player.URL = "Hey, Soul Sister";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox12.Checked == true && radioButton12.Checked == true)
            {
                label7.ForeColor = Color.Blue;
                label7.Text = "Correct";
                label8.ForeColor = Color.Blue;
                label8.Text = "Correct";
            }
            else
            {
                label7.ForeColor = Color.Red;
                label7.Text = "Incorrect";
                label8.ForeColor = Color.Red;
                label8.Text = "Incorrect";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {

            }
        }

        private void checkBox12_Click(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                checkBox12.Checked = true;
                checkBox11.Checked = false;
                checkBox10.Checked = false;
            }
        }

        private void checkBox11_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                checkBox12.Checked = false;
                checkBox11.Checked = true;
                checkBox10.Checked = false;
            }
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                checkBox12.Checked = false;
                checkBox11.Checked = false;
                checkBox10.Checked = true;
            }
        }

        private void radioButton12_Click(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                radioButton12.Checked = true;
                radioButton11.Checked = false;
                radioButton10.Checked = false;
            }
        }

        private void radioButton11_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton12.Checked = false;
                radioButton11.Checked = true;
                radioButton10.Checked = false;
            }
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                radioButton12.Checked = false;
                radioButton11.Checked = false;
                radioButton10.Checked = true;
            }
        }

        //======================================Question 5======================================//

        private void button15_Click(object sender, EventArgs e)
        {
            player.URL = "Khalid - Right Back.mp3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox15.Checked == true && radioButton15.Checked == true)
            {
                label9.ForeColor = Color.Blue;
                label9.Text = "Correct";
                label10.ForeColor = Color.Blue;
                label10.Text = "Correct";
            }
            else
            {
                label9.ForeColor = Color.Red;
                label9.Text = "Incorrect";
                label10.ForeColor = Color.Red;
                label10.Text = "Incorrect";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {

            }
        }

        private void checkBox15_Click(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                checkBox15.Checked = true;
                checkBox14.Checked = false;
                checkBox13.Checked = false;
            }
        }

        private void checkBox14_Click(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                checkBox15.Checked = false;
                checkBox14.Checked = true;
                checkBox13.Checked = false;
            }
        }

        private void checkBox13_Click(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                checkBox15.Checked = false;
                checkBox14.Checked = false;
                checkBox13.Checked = true;
            }
        }

        private void radioButton15_Click(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                radioButton15.Checked = true;
                radioButton14.Checked = false;
                radioButton13.Checked = false;
            }
        }

        private void radioButton14_Click(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
            {
                radioButton15.Checked = false;
                radioButton14.Checked = true;
                radioButton13.Checked = false;
            }
        }

        private void radioButton13_Click(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                radioButton15.Checked = false;
                radioButton14.Checked = false;
                radioButton13.Checked = true;
            }
        }

        //======================================Question 6======================================//

        private void button18_Click(object sender, EventArgs e)
        {
            player.URL = "Lalala.mp3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox18.Checked == true && radioButton18.Checked == true)
            {
                label11.ForeColor = Color.Blue;
                label11.Text = "Correct";
                label12.ForeColor = Color.Blue;
                label12.Text = "Correct";
            }
            else
            {
                label11.ForeColor = Color.Red;
                label11.Text = "Incorrect";
                label12.ForeColor = Color.Red;
                label12.Text = "Incorrect";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (radioButton18.Checked == true)
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

        private void radioButton18_Click(object sender, EventArgs e)
        {
            if (radioButton18.Checked == true)
            {
                radioButton18.Checked = true;
                radioButton17.Checked = false;
                radioButton16.Checked = false;
            }
        }

        private void radioButton17_Click(object sender, EventArgs e)
        {
            if (radioButton17.Checked == true)
            {
                radioButton18.Checked = false;
                radioButton17.Checked = true;
                radioButton16.Checked = false;
            }
        }

        private void radioButton16_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                radioButton18.Checked = false;
                radioButton17.Checked = false;
                radioButton16.Checked = true;
            }
        }

        //======================================Question 7======================================//

        private void button21_Click(object sender, EventArgs e)
        {
            player.URL = "Remember The Name.mp3";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox21.Checked == true && radioButton21.Checked == true)
            {
                label13.ForeColor = Color.Blue;
                label13.Text = "Correct";
                label14.ForeColor = Color.Blue;
                label14.Text = "Correct";
            }
            else
            {
                label13.ForeColor = Color.Red;
                label13.Text = "Incorrect";
                label14.ForeColor = Color.Red;
                label14.Text = "Incorrect";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (radioButton21.Checked == true)
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

        private void radioButton21_Click(object sender, EventArgs e)
        {
            if (radioButton21.Checked == true)
            {
                radioButton21.Checked = true;
                radioButton20.Checked = false;
                radioButton19.Checked = false;
            }
        }

        private void radioButton20_Click(object sender, EventArgs e)
        {
            if (radioButton20.Checked == true)
            {
                radioButton21.Checked = false;
                radioButton20.Checked = true;
                radioButton19.Checked = false;
            }
        }

        private void radioButton19_Click(object sender, EventArgs e)
        {
            if (radioButton19.Checked == true)
            {
                radioButton21.Checked = false;
                radioButton20.Checked = false;
                radioButton19.Checked = true;
            }
        }

        //======================================Question 8======================================//

        private void button24_Click(object sender, EventArgs e)
        {
            player.URL = "Señorita.mp3";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox24.Checked == true && radioButton24.Checked == true)
            {
                label15.ForeColor = Color.Blue;
                label15.Text = "Correct";
                label16.ForeColor = Color.Blue;
                label16.Text = "Correct";
            }
            else
            {
                label15.ForeColor = Color.Red;
                label15.Text = "Incorrect";
                label16.ForeColor = Color.Red;
                label16.Text = "Incorrect";
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (checkBox24.Checked == true)
            {

            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (radioButton24.Checked == true)
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

        private void radioButton24_Click(object sender, EventArgs e)
        {
            if (radioButton24.Checked == true)
            {
                radioButton24.Checked = false;
                radioButton23.Checked = false;
                radioButton22.Checked = true;
            }
        }

        private void radioButton23_Click(object sender, EventArgs e)
        {
            if (radioButton23.Checked == true)
            {
                radioButton24.Checked = false;
                radioButton23.Checked = false;
                radioButton22.Checked = true;
            }
        }

        private void radioButton22_Click(object sender, EventArgs e)
        {
            if (radioButton22.Checked == true)
            {
                radioButton24.Checked = false;
                radioButton23.Checked = false;
                radioButton22.Checked = true;
            }
        }

        //======================================Question 9======================================//

        private void button27_Click(object sender, EventArgs e)
        {
            player.URL = "Switch.mp3";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox27.Checked == true && radioButton27.Checked == true)
            {
                label17.ForeColor = Color.Blue;
                label17.Text = "Correct";
                label18.ForeColor = Color.Blue;
                label18.Text = "Correct";
            }
            else
            {
                label17.ForeColor = Color.Red;
                label17.Text = "Incorrect";
                label18.ForeColor = Color.Red;
                label18.Text = "Incorrect";
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (radioButton27.Checked == true)
            {

            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (checkBox27.Checked == true)
            {

            }
        }

        private void checkBox27_Click(object sender, EventArgs e)
        {
            if (checkBox27.Checked == true)
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

        private void radioButton27_Click(object sender, EventArgs e)
        {
            if (radioButton27.Checked == true)
            {
                radioButton27.Checked = true;
                radioButton26.Checked = false;
                radioButton25.Checked = false;
            }
        }

        private void radioButton26_Click(object sender, EventArgs e)
        {
            if (radioButton26.Checked == true)
            {
                radioButton27.Checked = false;
                radioButton26.Checked = true;
                radioButton25.Checked = false;
            }
        }

        private void radioButton25_Click(object sender, EventArgs e)
        {
            if (radioButton25.Checked == true)
            {
                radioButton27.Checked = false;
                radioButton26.Checked = false;
                radioButton25.Checked = true;
            }
        }

        //======================================Question 10======================================//

        private void button1_Click(object sender, EventArgs e)
        {
            player.URL = "That's What I Like.mp3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.controls.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            if (checkBox1.Checked == true && radioButton1.Checked == true)
            {
                label2.ForeColor = Color.Blue;
                label2.Text = "Correct";
                label1.ForeColor = Color.Blue;
                label1.Text = "Correct";
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Incorrect";
                label1.ForeColor = Color.Red;
                label1.Text = "Incorrect";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = true;
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
                radioButton3.Checked = false;
            }
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = true;
            }
        }

        private void _2_Player_Load(object sender, EventArgs e)
        {

        }

        private void button28_Click_1(object sender, EventArgs e)
        {

        }
    }
}
