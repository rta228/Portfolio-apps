using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

/* 
Zaprojektowac aplikacje ktora przy pomocy kontrolki data grid view pozwoli odnalezc wpisane do niej elementy 
nieparzyste (DODATNIE) i wyswietli ich sumy w postaci lancucha znakowego (STRING) 
zawierajacego znak plusa pomiedzy poszczegolnymi wartosciami
*/

/* 
 Obliczenie sumy z tych pol i wyswietli na ekranie w postaci nie zmienionego ciagu po ktorej pojawi sie znak rownosic a po nim wartosc
*/

/*

*/

namespace Zadanka_1
{
    public partial class Form1 : Form
    {
        int checker = 0;
        int sumOfThoseNim=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            label1.Text = ""; checker = 0; sumOfThoseNim=0;
            if (e.RowIndex >= 0)
            {
                sumOfThoseNim = 0;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    if (row.Cells[j].Value != null && int.Parse(row.Cells[j].Value.ToString())>0 && int.Parse(row.Cells[j].Value.ToString())%2==0)
                    {
                        sumOfThoseNim += int.Parse(row.Cells[j].Value.ToString());
                        if (checker == 0)
                        {
                            checker = 1;
                            label1.Text += row.Cells[j].Value.ToString();
                        }
                        else if (checker == 1)
                        {
                            label1.Text += " + "+row.Cells[j].Value.ToString();
                        }
                    }
                }
                label1.Text += " = " + sumOfThoseNim;
            }
        }
    }
}
