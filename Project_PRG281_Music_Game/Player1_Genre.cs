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

namespace Project_PRG281_Music_Game
{
    public partial class Player1_Genre : Form
    {
        public Player1_Genre()
        {
            InitializeComponent();
        }

        private void Player1_Genre_Load(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
            if(progressBar1.Value == 1)
            {
                MessageBox.Show("Time is Up!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdbPop.Checked == true)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Result","Answer was incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rdbKPop.Checked == true)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Result", "Answer was incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (rdbHipHop.Checked == true)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Result", "Answer was incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (rdbRNBQ4.Checked == true)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Result", "Answer was incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (rdbSoul.Checked == true)
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Result", "Answer was incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i = 1; i<= 100; i++)
            {
                Thread.Sleep(60000);
                backgroundWorker1.ReportProgress(i);
               
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = 1;
        }
    }
}
