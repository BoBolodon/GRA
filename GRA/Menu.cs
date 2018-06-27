using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRA
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            OdswiezProfil();
            Muzyczka();
        }

        public void Muzyczka()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@".\popcorn_vbr.wav");
            player.PlayLooping();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Napewno chesz wyjść?", "Wyjście?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                //...
            }
        }

        public void OdswiezProfil()
        {
            AktywnyProfil.Text = System.IO.File.ReadAllText(@".\AktywnyProfil.txt");
        }


        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormInfo Info = new FormInfo();
            Info.Show();
            this.Hide();
            Info.FormClosing += ShowMenu;
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            FormScore Score = new FormScore();
            Score.Show();
            this.Hide();
            Score.FormClosing += ShowMenu;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormProfil Profil = new FormProfil();
            Profil.Show();
            this.Hide();
            Profil.FormClosing += ShowMenu;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ComingSoon Settings = new ComingSoon();
            Settings.Show();
            this.Hide();
            Settings.FormClosing += ShowMenu;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            FormGame Game = new FormGame();
            Game.Show();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@".\popcorn_vbr.wav");
            player.Stop();
            this.Hide();
            Game.FormClosing += ShowMenu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormZmianaProfilu ZmianaProfilu = new FormZmianaProfilu();
            ZmianaProfilu.Show();
            this.Hide();
            ZmianaProfilu.FormClosing += ShowMenu;
        }

        private void ShowMenu(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }


        //super odkrycie 
        bool on = true;
        private void Mute_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@".\popcorn_vbr.wav");
            if (on)
            {
                this.Mute.Load(@".\img\mute.png");

                player.Stop();
                on = false;
            }

            else
            {
                this.Mute.Load(@".\img\unmute.png");
                player.PlayLooping();
                on = true;
            }

        }

    }
}
