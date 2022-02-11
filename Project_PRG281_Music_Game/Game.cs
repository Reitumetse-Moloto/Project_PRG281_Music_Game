using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG281_Music_Game
{
    public partial class Game : Form
    {
        private Button currentButton;
        private Random random;
        private int tempindex;
        private Form activeform;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Game()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(3000);

            InitializeComponent();

            t.Abort();

            random = new Random();
            //player.SoundLocation = "Pewdiepie sings.wav";
            btn_Home.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }
        public void StartForm()
        {
            Application.Run(new Splashscreen());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempindex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempindex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActiveB(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn_Home.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pn_Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(35, 41, 43);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
          
            player.PlayLooping();
        }
        private void Openchild(Form childForm, object btnsender)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            ActiveB(btnsender);
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pn_SubForms.Controls.Add(childForm);
            this.pn_SubForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_Title.Text = childForm.Text;
        }
        List<User> Alluser = new List<User>();
        Login log = new Login();
        private void btn_startGame_Hover(object sender, EventArgs e)
        {
            //this.Hide();
            //Game game = new Game();
            //game.Show();
            ActiveB(sender);
            Openchild(new Forms.GameStartMenu(), sender);
        }

        private void btn_Settings_Hover(object sender, EventArgs e)
        {
            ActiveB(sender);
            Openchild(new Forms.Settings(), sender);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            ActiveB(sender);
            Openchild(new Login(), sender);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (activeform != null)
            {
                activeform.Close();
                Reset();
            }
        }
        

        private void Reset()
        {
            DisableButton();
            lbl_Title.Text = "Music Genre Game";
            currentButton = null;
            btn_Home.Visible = false;
        }

        private void gpn_Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }


        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pn_SubForms_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
