using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Media;

namespace GRA
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
            pictureBoxSer.Hide();
        }



        
        
        Stopwatch sw = new Stopwatch();
        private void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            pictureBoxSer.Show();
            Random RandomObj = new Random();
            Point StartPoint = new Point(this.Size);

            int X = RandomObj.Next(20, ClientRectangle.Width - (pictureBoxSer.Width + 20));
            int Y = RandomObj.Next(50, ClientRectangle.Height - (pictureBoxSer.Height + 50));

            this.pictureBoxSer.Location = new Point(X, Y);

            sw.Start();
        }

        static int count = 0;
        private void pictureBoxSer_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@".\bite.wav");
            player.Play();
            Random RandomObj = new Random();
             Point StartPoint = new Point(this.Size);

             int X = RandomObj.Next(20, ClientRectangle.Width - (pictureBoxSer.Width + 20));
             int Y = RandomObj.Next(50, ClientRectangle.Height - (pictureBoxSer.Height + 50));

             this.pictureBoxSer.Location = new Point(X, Y);

             count++;
             int n = 5;
             string nserki = n.ToString();
             Licznik(nserki);

             if (count == n)
             {
                     sw.Stop();
                     TimeSpan ts = sw.Elapsed;
                     string czas = String.Format("{1:00}:{2:00}.{3:00}",
                     ts.Hours, ts.Minutes, ts.Seconds,
                     ts.Milliseconds / 10);
                     ZapisDoPliku(czas);   
                     MessageBox.Show("Myszka zjadła " + nserki + " serków w czasie " + czas);
                     count = 0;
                     sw.Reset();
                     Reset();
                     Start.Enabled = Enabled;
            }
        }
        public void Licznik(string nserki)
        {
            labelLicznik.Text = count.ToString() + "/" + nserki;
        }

        public void Reset()
        {
            pictureBoxSer.Hide();
            count = 0;
            sw.Stop();
            sw.Reset();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
            labelLicznik.Text = "--/--" ;
            Start.Enabled = true;
        }

        public void ZapisDoPliku(string czas)
        {
            string gracz = System.IO.File.ReadLines(@".\AktywnyProfil.txt").First();

            //string wynik =czas+","+gracz+","+DateTime.Today.ToString("dd-MM-yyyy") +","+ DateTime.Now.ToString("HH:mm:ss");
            string wynik = czas + "," + gracz+"";
            string path = @".\Wyniki.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(wynik);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(wynik);
                }
            }
        }


    }
}
