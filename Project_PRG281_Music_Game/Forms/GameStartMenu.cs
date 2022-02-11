using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG281_Music_Game.Forms
{
    public partial class GameStartMenu : Form
    {
        public GameStartMenu()
        {
            InitializeComponent();
        }

        private void GameStartMenu_Load(object sender, EventArgs e)
        {

        }

        private void gbtn_1P_Click(object sender, EventArgs e)
        {
            this.Hide();
            _1_Player player = new _1_Player();
            player.Show();

        }

        private void gbtn_2P_Click(object sender, EventArgs e)
        {
            
        }
    }
}
