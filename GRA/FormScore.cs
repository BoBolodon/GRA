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
    public partial class FormScore : Form
    {
        public FormScore()
        {
            InitializeComponent();
            CreateCollumns();
            ReadAndShowData();
        }

        private void CreateCollumns()
        {
            dataGridView1.Columns.Add("col1", "Wynik");
            dataGridView1.Columns.Add("col2", "Gracz");
            //dataGridView1.Columns.Add("col3", "Data");
            //dataGridView1.Columns.Add("col4", "Godzina");
        }

        private void ReadAndShowData()
        {
            //and so on...
            using (StreamReader sr = new StreamReader(@".\Wyniki.txt"))
            {
                int row = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] columns = line.Split(',');
                    dataGridView1.Rows.Add();
                    for (int i = 0; i < columns.Length; i++)
                    {
                        dataGridView1[i, row].Value = columns[i];
                    }
                    row++;
                }
                dataGridView1.Sort(this.dataGridView1.Columns["col1"], ListSortDirection.Ascending);

                //set autosize mode
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
