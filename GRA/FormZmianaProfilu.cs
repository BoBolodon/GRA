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
    public partial class FormZmianaProfilu : Form
    {
        public FormZmianaProfilu()
        {
            InitializeComponent();
            odswiezListeGraczy();
        }

        public void odswiezListeGraczy()
        {
            comboBoxSelectProfile.Items.Clear();
            string path = @".\Gracze.txt";
            string[] lineOfContents = File.ReadAllLines(path);
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                comboBoxSelectProfile.Items.Add(tokens[0]);
            }
        }

        private void buttonAktywujProfil_Click(object sender, EventArgs e)
        {
            string aktywnyProfil = comboBoxSelectProfile.Text;
            AktywacjaProfilu();
        }


        public void AktywacjaProfilu()
        {
            string path = @".\AktywnyProfil.txt";
            string gracz;
            if (string.IsNullOrWhiteSpace(comboBoxSelectProfile.Text))
            {
                MessageBox.Show("UWAGA! Nie wybrałeś profilu gracza", "BŁĄD");
            }
            else
            {
                gracz = comboBoxSelectProfile.Text.ToString();

                File.Delete(path);
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(gracz);
                    }

                FormMenu Menu = (FormMenu)Application.OpenForms["FormMenu"];
                Menu.OdswiezProfil();
                this.Close();
            }
        }




    }
}
