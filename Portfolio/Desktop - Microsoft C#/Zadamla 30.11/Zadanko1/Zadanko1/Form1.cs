using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Zaprojektowac aplikacje ktora pozwoli do tabeli o 5-ciu wierszach i 5 kolumnach wpisac w sposob automatyczny wartosci liczbowe
z zakersu od 1 do 25
*/

namespace Zadanko1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView2.RowCount = 1;
            dataGridView1.ColumnCount = 6;
            dataGridView1.RowCount = 0;
            int[] suma = new int[6];
            for (int i=0;i<=5;i++)
            {
                suma[i] = ((i * 0) + (i * 1) + (i * 2) + (i * 3) + (i * 4) + (i * 5));
            dataGridView1.Rows.Insert(i, (i * 0), (i * 1), (i * 2), (i * 3), (i * 4), (i * 5));
            }
            dataGridView1.Rows.Insert(0, suma[0], suma[1], suma[2], suma[3], suma[4], suma[5]);

            //Zaprojektowac alikacje ktora pozwoli uzytkownikowi
            //Pisac recznie wartosci do pol tabeli,a nastepnie za pomoca buttona przycisku wyczysci te pola

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.RowCount = 1;
        }
    }
}
