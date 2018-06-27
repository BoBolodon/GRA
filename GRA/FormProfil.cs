using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GRA
{
    public partial class FormProfil : Form
    {
        public FormProfil()
        {
            InitializeComponent();
        }

        public void ZapisDoPliku()
        {
            string gracz;
            if (string.IsNullOrWhiteSpace(textBoxNewProfileName.Text))
            {
                MessageBox.Show("UWAGA! Nie wpisałeś nazwy gracza", "BŁĄD");
            }
            else
            {
                gracz = textBoxNewProfileName.Text.ToString();
                string path = @".\Gracze.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(gracz);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(gracz);
                    }
                }
                this.Close();
            }
        }

        private void buttonCreateProfile_Click(object sender, EventArgs e)
        {
            ZapisDoPliku();
            textBoxNewProfileName.Text = String.Empty;
            //FormMenu f1 = (FormMenu)Application.OpenForms["Form1"]; //To jest fajne
            //f1.odswiezListeGraczy();
        }
    }
}
